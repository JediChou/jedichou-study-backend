namespace testlib.getData
{
    using System;
    using System.Collections.Generic;

    public class getInt
    {
        public static int random()
        {
            var rand = new Random();
            return rand.Next();
        }

        public static int random(int begin, int to)
        {
            var rand = new Random();
            return rand.Next(begin, to);
        }

        public static List<Int32> getIntList()
        {
            var intList = new List<Int32>();
            var counter = getInt.random(0, 1000);
            for (var i = 0; i <= counter; i++)
                intList.Add(getInt.random());

            return intList;
        }

        public static List<Int32> getIntList(Int32 Size)
        {
            var intList = new List<Int32>();
            for (var i = 0; i <= Size - 1; i++)
                intList.Add(getInt.random());

            return intList;
        }


        public static List<Int32> getIntList(Int32 Begin, Int32 To, Int32 Size)
        {
            var intList = new List<Int32>();
            for (var i = 0; i <= Size - 1; i++)
                intList.Add(getInt.random(Begin, To));
   
            return intList;
        }

        public static Array getIntArray()
        {
            return getInt.getIntList().ToArray();
        }
    }
}
