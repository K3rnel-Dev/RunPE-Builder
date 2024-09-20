# RunPE-Builder 2.0 * NEW *
![CSHARP](https://img.shields.io/badge/Language-CSHARP-boldgreen?style=for-the-badge&logo=csharp)
![Banner](banner.png)

## 🅰️ About:
```
RunPE-Builder is a tool designed to convert executable files into encrypted bytes. 
These bytes are then loaded into a stub by the builder, which decrypts and injects the executable code into legitimate processes during runtime. 
This technique enhances stealth by hiding the malicious payload in memory and executing it within the context of a trusted process
```
## 🖥️ Features ( UPDATE ): <b>
- Encryption of Executables ( xor ): Converts executable files into encrypted listings for add in stub
- In-Memory Decryption: Decrypts the executable code in memory to avoid detection by traditional file-based antivirus solutions
- Process Injection: Injects the decrypted executable code into legitimate processes, enhancing stealth and bypassing security mechanism
- User-Friendly Interface: Easy-to-use GUI for building and managing
- Obfuscation: Builder have obfuscation methods to which obfuscates the final file
- Autorun: Allows you to add your payload to autostart

## 🛡️ Update 20/09/2024:<b>
* Update encrypt-algorithm in stub: Was AES-256, became XOR
* Added algorithms for encryption of main strings (to prevent signature detection)
* Added new function Autorun
* Full redesigned using Guna.UI
* Added a conditional compilation method to prevent inclusion of code that is not used (according to the user's selected options)

## ⚙️ Note:
``` 
To change or redesign this project you need a: dnlib and Guna.UI
```

## ⚠️ Disclaimer:
```
The author assumes no responsibility for any misuse or illegal activities performed with this software.
Users are solely responsible for ensuring that their use of this tool complies with all applicable laws and regulations.
```
