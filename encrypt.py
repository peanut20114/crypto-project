from AES import AES 
from blowfish_cipher import BlowfishCipher
import os 
import argparse
# Example usage
key = b"12345678abcdefgh"
with open('iv.txt', 'rb') as file:
    iv = file.read()   # iv = os.urandom(16) 16-bytes IV


parser = argparse.ArgumentParser(description='Enter the path of the file to encrypt')
parser.add_argument('input_file', help='Path to the input MP4 file')
video_file_path = parser.parse_args().input_file


#Encrypt the first part using AES 
aes_bytes = AES.read_file_into_bytes(video_file_path)
encrypted_aes_bytes = AES.encrypt(key, iv, aes_bytes)


#Encrypt the second part using Blowfish
bf_bytes = BlowfishCipher.read_file_into_bytes(video_file_path)
encrypted_bf_bytes = BlowfishCipher.encrypt(key, bf_bytes)



### store into encrypted files:
enc_result = encrypted_aes_bytes + encrypted_bf_bytes
with open('Encrypted Video.mp4', 'wb') as file:
    file.write(enc_result)
    

