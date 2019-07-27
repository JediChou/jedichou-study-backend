// Reference by:
//   http://msdn.microsoft.com/zh-cn/library/system.security.cryptography.descryptoserviceprovider(v=vs.80).aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-4

// This sample demostrates using a key based on the
// the cryptographic service provider (CSP) version
// of the Data Encryption Standard (DES) algorithm to
// encrypt a string to a byte array, and then to decrypt
// the byte array back to a string.

using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

class CryptoMemoryStream
{
	// Program start !!!
	public static void Main()
	{
		// Create a new DES key.
		DESCryptoServiceProvider key = new DESCryptoServiceProvider();

		// Encrypt a string to a byte array.
		byte[] buffer = Encrypt("JediChou", key);
		foreach(byte ch in buffer)
			Console.Write(ch);
		Console.WriteLine();

		// Decrypt the byte array back to a string.
		string plaintext = Decrypt(buffer, key);

		// Display the plaintext value to the console.
		Console.WriteLine(plaintext);
	}

	/// <summary>
	/// Encrypt the string
	/// </summary>
	public static byte[] Encrypt(string PlainText, SymmetricAlgorithm key)
	{
		// Create a memory stream.
		MemoryStream ms = new MemoryStream();

		// Create a CryptoStream using the memory stream
		// and the CSP DES key.
		CryptoStream encStream = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);

		// Create a StreamWriter to write a string
		// to the stream
		StreamWriter sw = new StreamWriter(encStream);

		// Write the plaintext to the stream
		sw.WriteLine(PlainText);

		// Close the StreamWrite and CryptoStream.
		sw.Close();
		encStream.Close();

		// Get an array of bytes that represents
		byte[] buffer = ms.ToArray();

		// Close the memory stream.
		ms.Close();

		// Return the encrypted byte array
		return buffer;
	}

	///<summary>
	/// Decrypt the byte array.
	///</summary>
	public static string Decrypt(byte[] CypherText, SymmetricAlgorithm key)
	{
		// Create a memory stream to the passed buffer.
		MemoryStream ms = new MemoryStream(CypherText);

		// Create a CryptoStream using the memory stream and the
		// CSP DES key.
		CryptoStream encStream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);

		// Create a StreamReader for reading the stream.
		StreamReader sr = new StreamReader(encStream);

		// Read the stream as a string
		string val = sr.ReadLine();

		// Close the streams.
		sr.Close();
		encStream.Close();
		ms.Close();

		return val;
	}
}
