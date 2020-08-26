class Program
{
    static void Main(string[] args)
    {
        // Define a normal string object
        var str = "Jedi use vscode to execute a test. 中文内容呢？";
        System.Console.WriteLine($"str content: {str}");
        
        // Get str's byte array, and output to console.
        var bytesArr = GetBytes(str);
        System.Console.Write("str content(byte): ");
        foreach (var c in bytesArr)
            System.Console.Write(c);
        System.Console.WriteLine();

        // Get string content from byte array.
        var strCopy = GetString(bytesArr);
        System.Console.WriteLine($"strCopy content: {strCopy}");
    }

    static byte[] GetBytes(string str)
    {
        byte[] bytes = new byte[str.Length * sizeof(char)];
        System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
        return bytes;
    }

    static string GetString(byte[] bytes)
    {
        char[] chars = new char[bytes.Length / sizeof(char)];
        System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
        return new string(chars);
    }
}
