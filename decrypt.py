import os
from AES import AES
from blowfish_cipher import BlowfishCipher
import argparse

key = b"12345678abcdefgh"
with open('iv.txt', 'rb') as file:
    iv = file.read()   # iv = os.urandom(16) 16-bytes IV
parser = argparse.ArgumentParser(description='Enter the path of the file to decrypt')
parser.add_argument('input_file', help='Path to the input MP4 file')
video_file_path = parser.parse_args().input_file


with open(video_file_path, 'rb') as file:
    ciphertext = file.read()
    

enc_aes_bytes = ciphertext[:len(ciphertext)//2]
enc_bf_bytes = ciphertext[len(ciphertext)//2:]


dec_aes_bytes = AES.decrypt(key, iv, enc_aes_bytes)
dec_bf_bytes = BlowfishCipher.decrypt(key, enc_bf_bytes)

decrypt_result = dec_aes_bytes+dec_bf_bytes
with open('Decrypted video.mp4', 'wb') as file:
    file.write(decrypt_result)