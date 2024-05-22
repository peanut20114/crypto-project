from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from cryptography.hazmat.backends import default_backend
from cryptography.hazmat.primitives import padding
import os


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
        return file_bytes[:len(file_bytes)//2]

    # Write bytes to file
    def write_bytes_to_file(file_path, data):
        with open(file_path, 'wb') as file:
            file.write(data)
        