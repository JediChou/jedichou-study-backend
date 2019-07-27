/////////////////////////////////////////////
// Pls use lotid for DLP test
/////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;

namespace viewVariableMemory
{
    public class Program
    {
        static void Main()
        {
            lotid getlot = new lotid();
            Console.WriteLine(getlot.count());
            Console.WriteLine(getlot.pop());
            Console.WriteLine(getlot.pop());
            Console.WriteLine(getlot.count());
            Console.ReadLine();
        }
    }

    class lotid
    {
        public Hashtable hashtable = new Hashtable();

        public lotid()
        {
            for (int i = 1; i <= 20000; i++)
                this.hashtable.Add(i, "Object-" + i.ToString());
        }

        public string pop()
        {
            string temp;
            
            if (hashtable.Count != 0)
                temp = hashtable[hashtable.Count].ToString();
            else
                throw new Exception();

            hashtable.Remove(hashtable.Count);
            return temp;
        }

        public int count()
        {
            return hashtable.Count;
        }
    }
}
