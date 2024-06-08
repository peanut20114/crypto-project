# crypto-project

## How to use
### split
```python 
python split.py input-video.mp4 ouput chunk-duration
```

- input-video.mp4: The video to be splitted
- ouput: prefix for output video.
- chunk-duration: how long does a chunk video be splitted


### Script to run AES.py 
### Usage
```python 
 usage: python AES.py [-h] [--public_key PUBLIC_KEY] [--private_key PRIVATE_KEY] [--key_path KEY_PATH] [--iv_path IV_PATH] choice input_file

Enter the path of the file to encrypt or decrypt

positional arguments:
  choice                [Video|Key Encryption or Decryption]
  input_file            Path to the input MP4 file

options:
  -h, --help            show this help message and exit
  --public_key PUBLIC_KEY
                        Path to the receiver's public key (for encryption) or sender's public key (for decryption)
  --private_key PRIVATE_KEY
                        Path to the sender's private key (for encryption) or receiver's private key (for decryption)
  --key_path KEY_PATH
  --iv_path IV_PATH
```
#### Video Encryption
```python 
python AES.py encrypt input.mp4 
```

#### Video Decryption
```python
python test.py decrypt ./temp/ciphertext.txt --key_path ./temp/AESkey.txt --iv_path ./temp/AESiv.txt
```

#### Key Encryption 
```python
python test.py encryptAESkey ./temp/AESkey.txt --public_key ./temp/receiver_public_key.pem --private_key ./temp/sender_private_key.pem
```

#### Key Decryption 
```python 
python test.py decryptAESkey ./temp/AESkey.txt --public_key ./temp/sender_public_key.pem --private_key ./temp/receiver_private_key.pem
```
