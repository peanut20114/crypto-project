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
python AES.py 
usage: AES.py [-h] choice input_file public_key private_key

Enter the path of the file to encrypt or decrypt, path to public key, path to private key

positional arguments:
  choice       Encrypt or Decrypt
  input_file   Path to the input MP4 file
  public_key   Path to the receiver public key (for encryption) or sender public key (for decryption)
  private_key  Path to the sender private key (for encryption) or receiver private key (for decryption)
```
#### Encryption
```python 
python AES.py encrypt input.mp4 ./temp/receiver_public_key.pem ./temp/sender_private_key.pem
```

#### Decryption
```python
python AES.py decrypt ./temp/ciphertext.txt ./temp/sender_public_key.pem ./temp/receiver_private_key.pem
```
