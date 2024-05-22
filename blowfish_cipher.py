from Crypto.Cipher import Blowfish
from Crypto.Random import get_random_bytes
from struct import pack 
from Crypto.Util.Padding import pad, unpad
import os

class BlowfishCipher: 
    def read_file_into_bytes(file_path):
        with open(file_path, 'rb') as file:
            file_bytes = file.read()
        return file_bytes[len(file_bytes)//2:]
    
    @staticmethod
    def encrypt(key, plaintext):
        cipher = Blowfish.new(key, Blowfish.MODE_ECB)
        padded_plaintext = pad(plaintext, Blowfish.block_size)
        ciphertext = cipher.encrypt(padded_plaintext)
        return ciphertext

    @staticmethod
    def decrypt(key, ciphertext):
        cipher = Blowfish.new(key, Blowfish.MODE_ECB)
        decrypted_data = cipher.decrypt(ciphertext)
        plaintext = unpad(decrypted_data, Blowfish.block_size)
        return plaintext




