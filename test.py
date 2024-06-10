with open("D:/test_temp/iv.txt") as file: 
    iv = file.read()
    
    
    
print(len(iv))

import os 
niv = os.urandom(16)
print(len(niv))

with open('iv.txt', 'wb') as file: 
    file.write(niv)
    
with open('iv.txt', 'rb') as file: 
    aiv = file.read()
    
print(len(aiv))
