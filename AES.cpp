
#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#ifdef _WIN32
#include <windows.h>
#endif

#include <string>
using std::string;

#include <cstdlib>
using std::exit;

// #include "cryptopp/stdafx.h"
#include "assert.h"
#include "cryptopp/xts.h"
using CryptoPP::XTS;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include "cryptopp/cryptlib.h"
using CryptoPP::Exception;

#include "cryptopp/hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;

#include "cryptopp/filters.h"
using CryptoPP::StringSink;
using CryptoPP::StringSource;
using CryptoPP::StreamTransformationFilter;

#include "cryptopp/files.h"
using CryptoPP::FileSource;
using CryptoPP::FileSink;

#include "cryptopp/aes.h"
using CryptoPP::AES;

#include "cryptopp/ccm.h"
using CryptoPP::CBC_Mode;
using CryptoPP::OFB_Mode;
using CryptoPP::CTR_Mode;

#include "cryptopp/modes.h"
using CryptoPP::ECB_Mode;
using CryptoPP::CFB_Mode;

#include "cryptopp/gcm.h"
using CryptoPP::GCM;

#include "cryptopp/ccm.h"
using CryptoPP::CCM;

#ifndef DLL_EXPORT
    #ifdef _WIN32
        #define DLL_EXPORT __declspec(dllexport)
    #else
        #define DLL_EXPORT
    #endif
#endif

extern "C"{
    DLL_EXPORT void string2byte(std::string input, CryptoPP::byte output[CryptoPP::AES::DEFAULT_KEYLENGTH], size_t outputSize);
    DLL_EXPORT void file2byte(std::string& filename, CryptoPP::byte output[CryptoPP::AES::DEFAULT_KEYLENGTH]);
    DLL_EXPORT void AES_Random(const char* option, const char* plaintext);
    DLL_EXPORT void AES_Encrypt(const char* option, const char* secKey, const char* init_vec, const char* plaintext);
    DLL_EXPORT void AES_Decrypt(const char* option, const char* secKey, const char* init_vec, const char* ciphertext);
}

// Function to convert std::string to CryptoPP::byte array
void string2byte(std::string input, CryptoPP::byte output[CryptoPP::AES::DEFAULT_KEYLENGTH], size_t outputSize) {
    // Ensure the input length matches AES::DEFAULT_KEYLENGTH
    if (input.size() != outputSize) {
        throw std::invalid_argument("Input string length must be 16 bytes for AES-128 or 32 bytes for AES-XTS");
    }
    // Copy the string contents to the output byte array
    std::copy(input.begin(), input.end(), output);
}

// Function to read from file and convert to CryptoPP::byte array
void file2byte(std::string& filename, CryptoPP::byte output[CryptoPP::AES::DEFAULT_KEYLENGTH]) {
    std::string fileContent;

    // Read the file content using FileSource and StringSink
    CryptoPP::FileSource fileSource(filename.c_str(), true, 
        new CryptoPP::StringSink(fileContent));

    string encoded;
    StringSource(fileContent, true,
		new HexDecoder(
			new StringSink(encoded)
		) // HexDecoder
	); // StringSource

    // Ensure the file content length matches AES::DEFAULT_KEYLENGTH
    if (encoded.size() != CryptoPP::AES::DEFAULT_KEYLENGTH) {
        throw std::invalid_argument("File content length must be 16 bytes for AES-128.");
    }

    // Copy the string contents to the output byte array
    std::copy(encoded.begin(), encoded.end(), output);
}

void AES_Random(const char* option, const char* plaintext)
{
    string op = option;
    string plain = plaintext;
    string encoded, cipher, recovered;

    AutoSeededRandomPool prng;

    CryptoPP::byte key[AES::DEFAULT_KEYLENGTH];
    prng.GenerateBlock(key, sizeof(key));
    CryptoPP::byte iv[AES::BLOCKSIZE];
    prng.GenerateBlock(iv, sizeof(iv));

    encoded.clear();
    StringSource(key, sizeof(key), true,
        new HexEncoder(
            new StringSink(encoded)
        ) // HexEncoder
    ); // StringSource
    cout << "key: " << encoded << endl;

    encoded.clear();
    StringSource(iv, sizeof(iv), true,
        new HexEncoder(
            new StringSink(encoded)
        ) // HexEncoder
    ); // StringSource
    cout << "iv: " << encoded << endl;

    CryptoPP::CipherModeBase* e = nullptr;
    CryptoPP::CipherModeBase* d = nullptr;
    if (op == "ECB") {
        e = new CryptoPP::ECB_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::ECB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CBC") {
        e = new CryptoPP::CBC_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::CBC_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "OFB") {
        e = new CryptoPP::OFB_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::OFB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CFB") {
        e = new CryptoPP::CFB_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::CFB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CTR") {
        e = new CryptoPP::CTR_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::CTR_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "XTS") {
        e = new CryptoPP::XTS_Mode<CryptoPP::AES>::Encryption;
        d = new CryptoPP::XTS_Mode<CryptoPP::AES>::Decryption;
    }
    else {
        cerr << "Not support\n";
        exit(1);
    }

    // Setup Encryption & Decryption
    if (op == "ECB") {
        e->SetKey(key, sizeof(key));
        d->SetKey(key, sizeof(key));
    }
    else {
        e->SetKeyWithIV(key, sizeof(key), iv);
        d->SetKeyWithIV(key, sizeof(key), iv);
    }

    if (plain.find(".txt") != std::string::npos) {
        // Read the file content using FileSource and StringSink
        string fileContent;
        CryptoPP::FileSource fileSource(plain.c_str(), true, 
            new CryptoPP::StringSink(fileContent));
        plain = fileContent;
    }

    StringSource (plain, true, 
        new StreamTransformationFilter(*e,
            new StringSink(cipher)
        ) // StreamTransformationFilter
    ); // StringSource

	encoded.clear();
	StringSource(cipher, true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "cipher text: " << encoded << endl;

    StringSource (cipher, true, 
        new HexEncoder(
            new CryptoPP::FileSink("cipher.txt")
        )
    );

    StringSource (cipher, true, 
        new StreamTransformationFilter(*d,
            new StringSink(recovered)
        ) // StreamTransformationFilter
    ); // StringSource

    cout << "recovered text: " << recovered << endl;

    StringSource (recovered, true, 
        new HexEncoder(
            new CryptoPP::FileSink("recovered.txt")
        )
    );
}

void AES_Encrypt(const char* option, const char* secKey, const char* init_vec, const char* plaintext)
{
    string op = option;
    string m_key = secKey;
    string m_iv = init_vec;
    string plain = plaintext;
    string encoded, cipher;

    CryptoPP::byte key[AES::DEFAULT_KEYLENGTH];    
    CryptoPP::byte iv[AES::BLOCKSIZE];

    if (m_key.find(".txt") != std::string::npos && m_iv.find(".txt") != std::string::npos) {
        file2byte(m_key, key);
        file2byte(m_iv, iv);
    }
    else {
        if (op == "XTS") {
            string2byte(m_key, key, 32);
            string2byte(m_iv, iv, 32);
        }
        else {
            string2byte(m_key, key, 16);
            string2byte(m_iv, iv, 16);
        }
    }

    encoded.clear();
    StringSource(key, sizeof(key), true,
        new HexEncoder(
            new StringSink(encoded)
        ) // HexEncoder
    ); // StringSource
    cout << "key: " << encoded << endl;

    encoded.clear();
    StringSource(iv, sizeof(iv), true,
        new HexEncoder(
            new StringSink(encoded)
        ) // HexEncoder
    ); // StringSource
    cout << "iv: " << encoded << endl;

    // Encryption object pointer
    CryptoPP::CipherModeBase* e = nullptr;
    if (op == "ECB") {
        e = new CryptoPP::ECB_Mode<CryptoPP::AES>::Encryption;
    }
    else if (op == "CBC") {
        e = new CryptoPP::CBC_Mode<CryptoPP::AES>::Encryption;
    }
    else if (op == "OFB") {
        e = new CryptoPP::OFB_Mode<CryptoPP::AES>::Encryption;
    }
    else if (op == "CFB") {
        e = new CryptoPP::CFB_Mode<CryptoPP::AES>::Encryption;
    }
    else if (op == "CTR") {
        e = new CryptoPP::CTR_Mode<CryptoPP::AES>::Encryption;
    }
    else if (op == "XTS") {
        e = new CryptoPP::XTS_Mode<CryptoPP::AES>::Encryption;
    }
    else {
        cerr << "Not support\n";
        exit(1);
    }

    if (op == "ECB") {
        e->SetKey(key, sizeof(key));
    }
    else {
        e->SetKeyWithIV(key, sizeof(key), iv);
    }

    if (plain.find(".txt") != std::string::npos) {
        // Read the file content using FileSource and StringSink
        string fileContent;
        CryptoPP::FileSource fileSource(plain.c_str(), true, 
            new CryptoPP::StringSink(fileContent));
        plain = fileContent;
    }

    StringSource (plain, true, 
        new StreamTransformationFilter(*e,
            new StringSink(cipher)
        ) // StreamTransformationFilter
    ); // StringSource

	encoded.clear();
	StringSource(cipher, true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "cipher text: " << encoded << endl;

    StringSource (cipher, true, 
        new HexEncoder(
            new CryptoPP::FileSink("cipher.txt")
        )
    );
}

void AES_Decrypt(const char* option, const char* secKey, const char* init_vec, const char* ciphertext)
{
    string op = option;
    string m_key = secKey;
    string m_iv = init_vec;
    string encoded = ciphertext;
    string cipher, recovered;

    CryptoPP::byte key[AES::DEFAULT_KEYLENGTH];    
    CryptoPP::byte iv[AES::BLOCKSIZE];

    if (m_key.find(".txt") != std::string::npos && m_iv.find(".txt") != std::string::npos) {
        file2byte(m_key, key);
        file2byte(m_iv, iv);
    }
    else {
        if (op == "XTS") {
            string2byte(m_key, key, 32);
            string2byte(m_iv, iv, 32);
        }
        else {
            string2byte(m_key, key, 16);
            string2byte(m_iv, iv, 16);
        }
    }

    // Encryption object pointer
    CryptoPP::CipherModeBase* d = nullptr;
    if (op == "ECB") {
        d = new CryptoPP::ECB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CBC") {
        d = new CryptoPP::CBC_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "OFB") {
        d = new CryptoPP::OFB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CFB") {
        d = new CryptoPP::CFB_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "CTR") {
        d = new CryptoPP::CTR_Mode<CryptoPP::AES>::Decryption;
    }
    else if (op == "XTS") {
        d = new CryptoPP::XTS_Mode<CryptoPP::AES>::Decryption;
    }
    else {
        cerr << "Not support\n";
        exit(1);
    }

    if (op == "ECB") {
        d->SetKey(key, sizeof(key));
    }
    else {
        d->SetKeyWithIV(key, sizeof(key), iv);
    }

    if (encoded.find(".txt") != std::string::npos) {
        // Read the file content using FileSource and StringSink
        string fileContent;
        CryptoPP::FileSource fileSource(encoded.c_str(), true, 
            new CryptoPP::StringSink(fileContent));
        encoded = fileContent;
    }

    StringSource(encoded, true,
		new HexDecoder(
			new StringSink(cipher)
		) // HexEncoder
	); // StringSource

    StringSource (cipher, true, 
        new StreamTransformationFilter(*d,
            new StringSink(recovered)
        ) // StreamTransformationFilter
    ); // StringSource

    cout << "recovered text: " << recovered << endl;

    StringSource (recovered, true, 
        new HexEncoder(
            new CryptoPP::FileSink("recovered.txt")
        )
    );
}

int main(int argc, char* argv[])
{
    #ifdef _WIN32
	// Set console code page to UTF-8 on Windows C.utf8, CP_UTF8
	SetConsoleOutputCP(CP_UTF8);
	SetConsoleCP(CP_UTF8);
    #endif

    if (argc < 2) {
        cerr << "Usage: \n"
             << argv[0] << " encrypt <modes> <key> <iv> <plainText>\n"
             << argv[0] << " decrypt <modes> <key> <iv> <cipherText>\n"
             << "<modes>: [ECB|CBC|OFB|CFB|CTR|XTS|CCM|GCM]\n"
             << "<key> <iv>: [random|input|file]\n"
             << "<plainText> <cipherText>: [input|file]\n";
        return -1;
    }
 
    string mode = argv[1];
    string module = argv[2];
    string key_and_iv = argv[3];
 
    if (argc == 5) {
        if (key_and_iv == "random")
            AES_Random(argv[2], argv[4]);
        else if (module == "ECB" && mode == "encrypt")
            AES_Encrypt(argv[2], argv[3], argv[3], argv[4]);
        else if (module == "ECB" && mode == "decrypt")
            AES_Decrypt(argv[2], argv[3], argv[3], argv[4]);
    }
    else if (argc == 6) {
        if (mode == "encrypt")
            AES_Encrypt(argv[2], argv[3], argv[4], argv[5]);
        else if (mode == "decrypt")
            AES_Decrypt(argv[2], argv[3], argv[4], argv[5]);
    }
    else {
        cerr << "Invalid arguments. Please check the usage instructions.\n";
        return -1;
    }

	return 0;
}

