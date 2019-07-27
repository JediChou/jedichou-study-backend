// reference by:
// http://msdn.microsoft.com/zh-cn/library/system.security.cryptography.descryptoserviceprovider(v=vs.80).aspx?cs-save-lang=1&cs-lang=cpp#code-snippet-4

// This sample demostrates using a key based on the cryptographic
// service provider (CSP) version of the Data Encryption Standard
// (DES) algorithm to encrypt a string to a byte array, and then
// to decrypt the byte array bck to a string.

using namespace System;
using namespace System::IO;
using namespace System::Text;
using namespace System::Security::Cryptography;

// Create memory stream.
array<Byte>^ Encrypt(String^ PlainText, SymmetricAlgorithm^ key)
{
	// Create a memory stream.
	MemoryStream^ ms = gcnew MemoryStream;

	// Create a CryptoStream using the memory stream and
	// the CSP DES key
	CryptoStream^ encStream = gcnew CryptoStream(ms, key->CreateEncryptor(), CryptoStreamMode::Write);

	// Create a StreamWrite to write a string
	// to the stream.
	StreamWriter^ sw = gcnew StreamWriter(encStream);

	// Write the plaintext to the stream.
	sw->WriteLine(PlainText);

	// Close the StreamWriter and CryptoStream.
	sw->Close();
	encStream->Close();

	// Get an array of bytes that represents
	// the memory stream.
	array<Byte>^buffer = ms->ToArray();

	// Close the memory stream.
	ms->Close();

	// Return the encrypted byte array.
	return buffer;
}

// Decrypt the byte array.
String^ Decrypt( array<Byte>^ CypherText, SymmetricAlgorithm^ key)
{
	// Create a memory stream to the passed buffer.
	MemoryStream^ ms = gcnew MemoryStream(CypherText);

	// Create a CryptoStream using the memory stream and the
	// CSP DES key.
	CryptoStream^ encStream = gcnew CryptoStream(ms, key->CreateDecryptor(), CryptoStreamMode::Read);

	// Create a StreamReader for reading the stream.
	StreamReader^ sr = gcnew StreamReader(encStream);

	// Read the stream as a string.
	String^ val = sr->ReadLine();

	// Close the streams.
	sr->Close();
	encStream->Close();
	ms->Close();
	return val;
}

int main()
{
	// Create a new DES key.
	DESCryptoServiceProvider^ key = gcnew DESCryptoServiceProvider;

	// Encrypt a string to byte array.
	array<Byte>^ buffer = Encrypt("This is some plaintext!", key);
	for(int i=0; i<buffer->Length; i++)
		Console::Write(buffer[i]);
	Console::WriteLine();

	// Decrypt the byte array back to string.
	String^ plaintext = Decrypt(buffer, key);

	// Display the plaintext value to the console.
	Console::WriteLine(plaintext);

	return 0;
}
