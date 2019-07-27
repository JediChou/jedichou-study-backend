// File name: EncodeAndDecode-20150724-1115.cs
// Descrption 1: A simple encode and decode program.
// Descrption 2: Reversible encryption.

using System;

public class Program {
	public static void Main(string[] args) {
		// Define variables for plaintext and ciphertext
		// and execute encode, decode operation. 
		var mytext = "Hello world, 使用中文呢";
		var ende = new EnDecode();
		var en_text = ende.encode(mytext);
		var de_text = ende.decode(en_text);
		
		// Output result
		Console.WriteLine("plaintext : {0}", mytext);
		Console.WriteLine("en_text   : {0}", en_text);
		Console.WriteLine("de_text   : {0}", de_text);
		Console.WriteLine(mytext == de_text);
		
		// Press key to exit program
		Console.ReadKey();
	}
}

/// <summary>
/// Interface of Encryption and Decryption
/// </summary>
public interface IBindesh {
	string encode(string str);
	string decode(string str);
}

/// <summary>
/// Provide Encrypt and Decrypt
/// </summary>
public class EnDecode : IBindesh {
	/// <summary>
	/// Encrypt method
	/// </summary>
	/// <param name="str">Plaintext</param>
	/// <returns>Ciphertext</returns>
	public string encode(string str) {
		string htext = String.Empty;
		for(int i=0; i<str.Length; i++)
			htext += (char)(str[i]+10-1*2);
		return htext;
	}
	
	/// <summary>
	/// Decrypt method
	/// </summary>
	/// <param name="str">Ciphertext</param>
	/// <returns>Plaintext</returns>
	public string decode(string str) {
		string dtext = String.Empty;
		for(int i=0; i<str.Length; i++)
			dtext += (char)(str[i]-10+1*2);
		return dtext;
	}
}