import os
from os import system, path
import argparse
import random 
try: 
    import cryptography
    from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    from cryptography.hazmat.backends import default_backend
    from cryptography.hazmat.primitives import padding, hashes, serialization
    from cryptography.hazmat.primitives.asymmetric import ec
    from cryptography.hazmat.primitives.kdf.hkdf import HKDF
    from cryptography.hazmat.primitives.ciphers.aead import AESGCM
    import base64 

except: 
    system("pip install cryptography")
    import cryptography
    from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    from cryptography.hazmat.backends import default_backend
    from cryptography.hazmat.primitives import padding, hashes, serialization
    from cryptography.hazmat.primitives.asymmetric import ec
    from cryptography.hazmat.primitives.kdf.hkdf import HKDF
    from cryptography.hazmat.primitives.ciphers.aead import AESGCM
    import base64 
    
class AES:
    @staticmethod
    def encrypt(key, iv, plaintext):
        # Create a padder instance
        padder = padding.PKCS7(algorithms.AES.block_size).padder()
        # Add padding to the plaintext
        padded_plaintext = padder.update(plaintext) + padder.finalize()
        # Encrypt the padded plaintext
        backend = default_backend()
        cipher = Cipher(algorithms.AES(key), modes.CBC(iv), backend=backend)
        encryptor = cipher.encryptor()
        ciphertext = encryptor.update(padded_plaintext) + encryptor.finalize()
        return ciphertext

    @staticmethod
    def decrypt(key, iv, ciphertext):
        # Decrypt the ciphertext
        backend = default_backend()
        cipher = Cipher(algorithms.AES(key), modes.CBC(iv), backend=backend)
        decryptor = cipher.decryptor()
        decrypted_data = decryptor.update(ciphertext) + decryptor.finalize()
        # Create an unpadder instance
        unpadder = padding.PKCS7(algorithms.AES.block_size).unpadder()
        # Remove padding from the decrypted data
        plaintext = unpadder.update(decrypted_data) + unpadder.finalize()
        return plaintext

    # Read video file into bytes
    def read_file_into_bytes(file_path):
        with open(file_path, 'rb') as file:
            file_bytes = file.read()
        return file_bytes

    # Write bytes to file
    def write_bytes_to_file(file_path, data):
        with open(file_path, 'wb') as file:
            file.write(data)
            
            
parser = argparse.ArgumentParser(description='Enter the path of the file to encrypt')
parser.add_argument('choice', help='Encrypt or Decrypt')
parser.add_argument('input_file', help='Path to the input MP4 file')
file_name = parser.parse_args().input_file          
choice = parser.parse_args().choice

script_dir = path.dirname(__file__) #<-- absolute dir the script is in
rel_path = "/temp/" 

save_path = path.join(script_dir, rel_path)
print("script path:", script_dir)
print('abs_file:', save_path)

def generateRandomKeyandIV():
    key = os.urandom(16)
    iv = os.urandom(16)
    with open('temp/AESkey.txt', 'wb') as file: 
        file.write(key)
    with open('temp/AESiv.txt', 'wb') as file: 
        file.write(iv) 
    return key, iv

def encryptAESkey(key, private_key, public_key):
    private_key = serialization.load_der_private_key(private_key, None)
    public_key = serialization.load_der_public_key(public_key)
    shared_key = private_key.exchange(ec.ECDH(), public_key)

    # Perform key derivation.
    derived_key = HKDF(
        algorithm=hashes.SHA256(),
        length=32,
        salt=None,
        info=None,
    ).derive(shared_key)

    # Encrypt the AES key with the derived key
    iv = os.urandom(16) # this iv is used for aes key encryption 
    with open('temp/iv.txt', 'wb') as file: 
        file.write(iv)
    cipher = Cipher(algorithms.AES(derived_key), modes.CBC(iv))
    encryptor = cipher.encryptor()
    padder = padding.PKCS7(128).padder()
    padded_data = padder.update(key) + padder.finalize()
    encrypted_aes_key = encryptor.update(padded_data) + encryptor.finalize()
    
    return encrypted_aes_key

def decryptAESkey(encrypted_aes_key, private_key, public_key):
    private_key = serialization.load_der_private_key(private_key, None)
    public_key = serialization.load_der_public_key(public_key)
    shared_key = private_key.exchange(ec.ECDH(), public_key)

    # Perform key derivation.
    derived_key = HKDF(
        algorithm=hashes.SHA256(),
        length=32,
        salt=None,
        info=None,
    ).derive(shared_key)

    # Decrypt the AES key with the derived key
    with open('temp/iv.txt', 'rb') as file: 
        iv = file.read()
    cipher = Cipher(algorithms.AES(derived_key), modes.CBC(iv))
    decryptor = cipher.decryptor()
    unpadder = padding.PKCS7(128).unpadder()
    decrypted_data = decryptor.update(encrypted_aes_key) + decryptor.finalize()
    key = unpadder.update(decrypted_data) + unpadder.finalize()
    
    return key
        
def encryptVideo(file_name, private_key, public_key):
    key, iv = generateRandomKeyandIV()
    aes_bytes = AES.read_file_into_bytes(file_name)
    encrypted_aes_bytes = AES.encrypt(key, iv, aes_bytes)
    
    # # Your base64 strings
    # private_key_base64 = "MHcCAQEEIG1tm0lTR0XNgKsu33uyeP4ScxLkJ3ImTvnf3o47riZSoAoGCCqGSM49AwEHoUQDQgAES2cnfMIGauK4mqhTcc0dMXEjLAmcAy9tgJ5wXdCVwfRCrZrk4NdkBDOn2anwvxTMo4nzph8JtVM+ORMWf39ITQ=="
    # public_key_base64 = "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAES2cnfMIGauK4mqhTcc0dMXEjLAmcAy9tgJ5wXdCVwfRCrZrk4NdkBDOn2anwvxTMo4nzph8JtVM+ORMWf39ITQ=="

    # Convert base64 strings to bytes
    private_key = base64.b64decode(private_key)
    public_key = base64.b64decode(public_key)

    print("Private Key Bytes:", private_key)
    print("Public Key Bytes:", public_key)
    
    with open('temp/ciphertext.txt' , 'wb') as file: 
        file.write(encrypted_aes_bytes)
    with open('temp/encryptedAESkey.txt', 'wb') as file: 
        file.write(encryptAESkey(key, private_key, public_key))
    
def decryptVideo(file_name, private_key, public_key):
    with open('temp/encryptedAESkey.txt', 'rb') as file: 
        encrypted_aes_key = file.read()
        
    with open('temp/AESiv.txt', 'rb') as file: 
        iv = file.read()  
    #  # Your base64 strings
    # private_key_base64 = "MHcCAQEEIG1tm0lTR0XNgKsu33uyeP4ScxLkJ3ImTvnf3o47riZSoAoGCCqGSM49AwEHoUQDQgAES2cnfMIGauK4mqhTcc0dMXEjLAmcAy9tgJ5wXdCVwfRCrZrk4NdkBDOn2anwvxTMo4nzph8JtVM+ORMWf39ITQ=="
    # public_key_base64 = "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAES2cnfMIGauK4mqhTcc0dMXEjLAmcAy9tgJ5wXdCVwfRCrZrk4NdkBDOn2anwvxTMo4nzph8JtVM+ORMWf39ITQ=="

    # Convert base64 strings to bytes
    private_key = base64.b64decode(private_key)
    public_key = base64.b64decode(public_key)
    key = decryptAESkey(encrypted_aes_key, private_key, public_key)
    encrypted_aes_bytes = AES.read_file_into_bytes(file_name)
    recovered = AES.decrypt(key, iv, encrypted_aes_bytes)
    with open('temp/recovered.mp4' , 'wb') as file: 
        file.write(recovered)

if choice == "encrypt":
    encryptVideo(file_name)
elif choice == "decrypt":
    decryptVideo(file_name)
else: 
    print("Not supported!!!!") 
    exit(1)
    
    

