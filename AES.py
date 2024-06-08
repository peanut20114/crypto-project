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
            
            
def generateRandomKeyandIV():
    # Generate random 128-bit key and IV
    key = os.urandom(16)
    iv = os.urandom(16)
    with open('temp/AESkey.txt', 'wb') as file: 
        file.write(key)
    with open('temp/AESiv.txt', 'wb') as file: 
        file.write(iv) 
    return key, iv

def encryptAESkey(key_path, sender_private_key_path, receiver_public_key_path):
    # When sharing the encrypted video, 
    # the key is encrypted with sender private key and receiver publickey
    with open(key_path, 'rb') as file: 
        key = file.read()
    with open(sender_private_key_path, 'rb') as key_file:
        sender_private_key_pem = key_file.read()
    with open(receiver_public_key_path, 'rb') as key_file:
        receiver_public_key_pem = key_file.read()
    
    sender_private_key = serialization.load_pem_private_key(sender_private_key_pem, password=None)
    receiver_public_key = serialization.load_pem_public_key(receiver_public_key_pem)
    shared_key = sender_private_key.exchange(ec.ECDH(), receiver_public_key)

    derived_key = HKDF(
        algorithm=hashes.SHA256(),
        length=32,
        salt=None,
        info=None,
    ).derive(shared_key)

    iv = os.urandom(16)
    with open('temp/iv.txt', 'wb') as file: 
        file.write(iv)
    cipher = Cipher(algorithms.AES(derived_key), modes.CBC(iv))
    encryptor = cipher.encryptor()
    padder = padding.PKCS7(128).padder()
    padded_data = padder.update(key) + padder.finalize()
    encrypted_aes_key = encryptor.update(padded_data) + encryptor.finalize()
    with open('temp/AESkey.txt', 'wb') as file: 
        file.write(encrypted_aes_key)
    return encrypted_aes_key

def decryptAESkey(encrypted_aes_key_path, receiver_private_key_path, sender_public_key_path):
    with open(encrypted_aes_key_path, 'rb') as file: 
        encrypted_aes_key = file.read()
    with open(receiver_private_key_path, 'rb') as key_file:
        receiver_private_key_pem = key_file.read()
    with open(sender_public_key_path, 'rb') as key_file:
        sender_public_key_pem = key_file.read()
    receiver_private_key = serialization.load_pem_private_key(receiver_private_key_pem, password=None)
    sender_public_key = serialization.load_pem_public_key(sender_public_key_pem)
    shared_key = receiver_private_key.exchange(ec.ECDH(), sender_public_key)

    derived_key = HKDF(
        algorithm=hashes.SHA256(),
        length=32,
        salt=None,
        info=None,
    ).derive(shared_key)

    with open('temp/iv.txt', 'rb') as file: 
        iv = file.read()
    cipher = Cipher(algorithms.AES(derived_key), modes.CBC(iv))
    decryptor = cipher.decryptor()
    unpadder = padding.PKCS7(128).unpadder()
    decrypted_data = decryptor.update(encrypted_aes_key) + decryptor.finalize()
    key = unpadder.update(decrypted_data) + unpadder.finalize()
    with open(encrypted_aes_key_path, 'wb') as file: 
        file.write(key)
    return key

def encryptVideo(file_name):
    # Generate random key and iv, encrypt the video and store in ciphertext 
    key, iv = generateRandomKeyandIV()
    aes_bytes = AES.read_file_into_bytes(file_name)
    encrypted_aes_bytes = AES.encrypt(key, iv, aes_bytes)
    
    with open('temp/ciphertext.txt', 'wb') as file: 
        file.write(encrypted_aes_bytes)
    
   

def decryptVideo(file_name, key_path, iv_path):
    with open(key_path, 'rb') as file: 
       key = file.read()
        
    with open(iv_path, 'rb') as file: 
        iv = file.read()

    encrypted_aes_bytes = AES.read_file_into_bytes(file_name)
    recovered = AES.decrypt(key, iv, encrypted_aes_bytes)
    with open('temp/recovered.mp4', 'wb') as file: 
        file.write(recovered)

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description='Enter the path of the file to encrypt or decrypt')
    parser.add_argument('choice', help='[Video|Key Encryption or Decryption]')
    parser.add_argument('input_file', help='Path to the input MP4 file')
    parser.add_argument('--public_key', help="Path to the receiver's public key (for encryption) or sender's public key (for decryption)", default=None)
    parser.add_argument('--private_key', help="Path to the sender's private key (for encryption) or receiver's private key (for decryption)", default=None)
    parser.add_argument('--key_path', default=None)
    parser.add_argument('--iv_path', default=None)
    args = parser.parse_args()

    file_name = args.input_file
    choice = args.choice
    public_key_path = args.public_key
    private_key_path = args.private_key
    key_path = args.key_path 
    iv_path = args.iv_path
    
    if choice.lower() == "encrypt":
        encryptVideo(file_name)
    elif choice.lower() == "decrypt":
        if not key_path or not iv_path:
            print("key_path and iv_path are required for decrypting a video.")
            exit(1)
        decryptVideo(file_name, key_path, iv_path)
    elif choice.lower() == "encryptaeskey":
        if not file_name and not private_key_path and not public_key_path:
            print("Sender private key and receiver public key are required to encrypt AES key")
            exit(1)
        encryptAESkey(file_name, private_key_path, public_key_path)
    elif choice.lower() == "decryptaeskey":
        decryptAESkey(file_name, private_key_path, public_key_path)
        
    else:
        print("Invalid choice. Supported choices are: encrypt, decrypt, encryptAESkey, decryptAESkey.")
        exit(1)
