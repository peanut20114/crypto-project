import os
from os import system, path
import argparse

try: 
    import cryptography
    from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    from cryptography.hazmat.backends import default_backend
    from cryptography.hazmat.primitives import padding
except: 
    system("pip install cryptography")
    import cryptography
    from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    from cryptography.hazmat.backends import default_backend
    from cryptography.hazmat.primitives import padding

class AES:
    @staticmethod
    def encrypt(key, iv, plaintext):
        backend = default_backend()
        cipher = Cipher(algorithms.AES(key), modes.CBC(iv), backend=backend)
        encryptor = cipher.encryptor()
        padder = padding.PKCS7(algorithms.AES.block_size).padder()
        padded_plaintext = padder.update(plaintext) + padder.finalize()
        ciphertext = encryptor.update(padded_plaintext) + encryptor.finalize()
        return ciphertext

    @staticmethod
    def decrypt(key, iv, ciphertext):
        backend = default_backend()
        cipher = Cipher(algorithms.AES(key), modes.CBC(iv), backend=backend)
        decryptor = cipher.decryptor()
        decrypted_data = decryptor.update(ciphertext) + decryptor.finalize()
        unpadder = padding.PKCS7(algorithms.AES.block_size).unpadder()
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
rel_path = "/video/" 

save_path = path.join(script_dir, rel_path)
print("script path:", script_dir)
print('abs_file:', save_path)

key = b"12345678abcdefgh"
with open('iv.txt', 'rb') as file:
    iv = file.read()   # iv = os.urandom(16) 16-bytes IV
        
def encryptVideo(file_name):
    aes_bytes = AES.read_file_into_bytes(file_name)
    encrypted_aes_bytes = AES.encrypt(key, iv, aes_bytes)
    with open('video/ciphertext.txt' , 'wb') as file: 
        file.write(encrypted_aes_bytes)
    
def decryptVideo(file_name):
    encrypted_aes_bytes = AES.read_file_into_bytes(file_name)
    recovered = AES.decrypt(key, iv, encrypted_aes_bytes)
    with open('video/recovered.mp4' , 'wb') as file: 
        file.write(recovered)

if choice == "encrypt":
    encryptVideo(file_name)
elif choice == "decrypt":
    decryptVideo(file_name)
else: 
    print("Not supported!!!!") 
    exit(1)
