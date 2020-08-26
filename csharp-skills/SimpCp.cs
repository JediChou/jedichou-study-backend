using System;
using System.IO;

class Program {
    static void Main (string[] args) {
        string src = @"d:\test1.txt", tgt = @"d:\test2.txt";
        using (var fs = new FileStream (src, FileMode.Open)) {
            CopyStream (fs, tgt);
        }
    }

    static void CopyStream (Stream stream, string destPath) {
        using (var fs = new FileStream (destPath, FileMode.Create, FileAccess.Write))
        stream.CopyTo (fs);
    }
}