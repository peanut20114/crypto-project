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
#### Encryption
```python 
python AES.py encrypt input.mp4 ./temp/receiver_public_key.pem ./temp/sender_private_key.pem
```

#### Decryption
```python
python AES.py decrypt ./temp/ciphertext.txt ./temp/sender_public_key.pem ./temp/receiver_private_key.pem
```
