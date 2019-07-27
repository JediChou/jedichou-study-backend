namespace cslab.ProgramPuzzle
{
    /// <summary>
    /// Tittle: Deleting a digit
    /// English Description:
    ///   Find the number of 5-digit positive integers n that have the following property: 
    ///   If we delete any digit in n, then we get a 4-digit number which is always divisible 
    ///   by 7. I tried using modulo congruences but it got tedious. I asked this question 
    ///   on Math Stack Exchange and someone there suggested to make a program. I know only C, 
    ///   so a solution in C is welcome. Also, is 2 the correct answer?(77777,77770)
    /// 
    /// Reference Url:
    ///   http://codegolf.stackexchange.com/questions/45527/deleting-a-digit
    /// </summary>
    class DeletingADigitSlowAnswer
    {
        /// <summary>
        /// Run this method, you will get answer!
        /// </summary>
        public static void Run()
        {
            for (var i = 10000; i <= 99999; i++)
            {
                var a = GetBit(i, 5);
                var b = GetBit(i - a * 10000, 4);
                var c = GetBit(i - b * 1000, 3);
                var d = GetBit(i - c * 100, 2);
                var e = GetBit(i - d * 10, 1);
                if (Check(a, b, c, d, e) && i > 10000)
                    System.Console.Write(i + ", ");
            }
        }

        public static int GetBit(int a, int length)
        {
            var div = (int)System.Math.Pow(10, length - 1);
            return (a - a % div) / div;
        }

        public static bool Check(int a, int b, int c, int d, int e)
        {
            return (b != 0) && ((b * 1000 + c * 100 + d * 10 + e) % 7 == 0 &&
                                (a * 1000 + c * 100 + d * 10 + e) % 7 == 0 &&
                                (a * 1000 + b * 100 + d * 10 + e) % 7 == 0 &&
                                (a * 1000 + b * 100 + c * 10 + e) % 7 == 0 &&
                                (a * 1000 + b * 100 + c * 10 + d) % 7 == 0);
        }
    }
}
