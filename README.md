# Encrypting---Decrypting
The project was the small work on encrypting and decrypting data such as images, music tracks etc.


The programm is supposed to encrypt and decrypt data fo different types *(.jpeg, .mp3 etc)* with Advanced Encryption Standard (Rijndael) which is the symmetric type of encryption. Implementation was followed by using already existing library System.Security.Cryptography in C\#.

A user can choose the file from their desktop - choose the folder they want to save the file in  - encrypt it with a given key - decrypt it if one is willing to do so.

During the whole process one can track the repositories and files that were encrypted or decrypted. In addition to this, the .exe file also allows to download the file from a given URL, that particularly must contain the file. For example, URL should end with .jpeg in the end.
