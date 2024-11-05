# CryptographyToolkit

CryptographyToolkit is a suite of cryptographic tools that provides encryption, decryption, and cipher-breaking functionalities using classical algorithms such as the **Caesar Cipher** and **Vigenère Cipher**.

## Table of Contents
- [Requirements](#requirements)
- [Installation](#installation)
- [Features](#features)
- [Usage](#usage)
- [License](#license)

## Requirements
- **.NET 7.0** or higher
- Supported on Windows, macOS, and Linux

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/kacperrymkiewicz/CryptoToolkit
   ```
   
## Features
### Caesar Cipher App
- Encrypt and Decrypt text using the Caesar Cipher.
- Break Caesar Cipher using letter frequency analysis based on Polish language letter frequencies.
### Vigenère Cipher App
- Encrypt and Decrypt text using the Vigenère Cipher with a given key.
### Caesar Cipher Breaker
- Break Caesar Cipher: Attempts to decrypt Caesar-ciphered text by identifying the most frequent letters and suggesting likely plaintexts based on the Polish language.

## Usage

### Caesar Cipher
```plaintext
Choose an option:
1. Encrypt text
2. Decrypt text
```
## License
This project is licensed under the MIT License. See LICENSE for details.
