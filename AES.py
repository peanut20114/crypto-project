import os
from os import system, path
import argparse
import random
try:
    import cryptography
    from cryptography.hazmat.primitives.ciphers.aead import AESGCM
    from cryptography.hazmat.primitives import hashes, serialization
    from cryptography.hazmat.primitives.asymmetric import ec
    from cryptography.hazmat.primitives.kdf.hkdf import HKDF
    import base64
except:
    system("pip install cryptography")
    from cryptography.hazmat.primitives.ciphers.aead import AESGCM
    from cryptography.hazmat.primitives import hashes, serialization
    from cryptography.hazmat.primitives.asymmetric import ec
    from cryptography.hazmat.primitives.kdf.hkdf import HKDF
    import base64

class AES:
    @staticmethod
    def encrypt(key, nonce, plaintext):
        aesgcm = AESGCM(key)
        ciphertext = aesgcm.encrypt(nonce, plaintext, None)
        return ciphertext

    @staticmethod
    def decrypt(key, nonce, ciphertext):
        aesgcm = AESGCM(key)
        plaintext = aesgcm.decrypt(nonce, ciphertext, None)
        return plaintext

    @staticmethod
    def read_file_into_bytes(file_path):
        with open(file_path, 'rb') as file:
            file_bytes = file.read()
        return file_bytes

    @staticmethod
    def write_bytes_to_file(file_path, data):
        with open(file_path, 'wb') as file:
            file.write(data)

def generateRandomKeyAndNonce(output_dir):
    key = AESGCM.generate_key(bit_length=128)
    nonce = os.urandom(12)
    if not os.path.exists(output_dir):
        os.makedirs(output_dir)
    with open(os.path.join(output_dir, 'AESkey.txt'), 'wb') as file:
        file.write(key)
    with open(os.path.join(output_dir, 'AESnonce.txt'), 'wb') as file:
        file.write(nonce)
    return key, nonce

def encryptAESkey(key_path, sender_private_key_path, receiver_public_key_path, output_dir):
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

    nonce = os.urandom(12)
    with open(os.path.join(output_dir, 'nonce.txt'), 'wb') as file:
        file.write(nonce)
    
    aesgcm = AESGCM(derived_key)
    encrypted_aes_key = aesgcm.encrypt(nonce, key, None)
    
    with open(os.path.join(output_dir, 'AESkey.txt'), 'wb') as file:
        file.write(encrypted_aes_key)
    return encrypted_aes_key

def decryptAESkey(encrypted_aes_key_path, receiver_private_key_path, sender_public_key_path, output_dir):
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

    with open(os.path.join(output_dir, 'nonce.txt'), 'rb') as file:
        nonce = file.read()
    
    aesgcm = AESGCM(derived_key)
    key = aesgcm.decrypt(nonce, encrypted_aes_key, None)
    
    with open(encrypted_aes_key_path, 'wb') as file:
        file.write(key)
    return key

def encryptVideo(file_name):
    base_file_name = os.path.splitext(os.path.basename(file_name))[0]
    output_dir = f'D:/{base_file_name}_temp'
    key, nonce = generateRandomKeyAndNonce(output_dir)
    aes_bytes = AES.read_file_into_bytes(file_name)
    encrypted_aes_bytes = AES.encrypt(key, nonce, aes_bytes)
    output_name = base_file_name + '.txt'
    encrypted_file_path = os.path.join(output_dir, output_name)
    AES.write_bytes_to_file(encrypted_file_path, encrypted_aes_bytes)
    return encrypted_file_path

def decryptVideo(file_name, key_path, nonce_path):
    base_file_name = os.path.splitext(os.path.basename(file_name))[0]
    output_dir = f'D:/{base_file_name}_temp'

    with open(key_path, 'rb') as file:
        key = file.read()

    with open(nonce_path, 'rb') as file:
        nonce = file.read()

    encrypted_aes_bytes = AES.read_file_into_bytes(file_name)
    recovered = AES.decrypt(key, nonce, encrypted_aes_bytes)
    recovered_file_path = os.path.join(output_dir, 'recovered.mp4')
    AES.write_bytes_to_file(recovered_file_path, recovered)
    return recovered_file_path

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description='Enter the path of the file to encrypt or decrypt')
    parser.add_argument('choice', help='[Video|Key Encryption or Decryption]')
    parser.add_argument('input_file', help='Path to the input MP4 file')
    parser.add_argument('--public_key', help="Path to the receiver's public key (for encryption) or sender's public key (for decryption)", default=None)
    parser.add_argument('--private_key', help="Path to the sender's private key (for encryption) or receiver's private key (for decryption)", default=None)
    parser.add_argument('--key_path', default=None)
    parser.add_argument('--nonce_path', default=None)
    parser.add_argument('--output_dir', default=None)
    args = parser.parse_args()

    file_name = args.input_file
    choice = args.choice
    public_key_path = args.public_key
    private_key_path = args.private_key
    key_path = args.key_path
    nonce_path = args.nonce_path
    output_dir = args.output_dir

    if choice.lower() == "encrypt":
        encryptVideo(file_name)
    elif choice.lower() == "decrypt":
        if not key_path or not nonce_path:
            print("key_path and nonce_path are required for decrypting a video.")
            exit(1)
        decryptVideo(file_name, key_path, nonce_path)
    elif choice.lower() == "encryptaeskey":
        if not file_name or not private_key_path or not public_key_path:
            print("Sender private key and receiver public key are required to encrypt AES key")
            exit(1)
        encryptAESkey(file_name, private_key_path, public_key_path, output_dir)
    elif choice.lower() == "decryptaeskey":
        decryptAESkey(file_name, private_key_path, public_key_path, output_dir)
    else:
        print("Invalid choice. Supported choices are: encrypt, decrypt, encryptAESkey, decryptAESkey.")
        exit(1)
