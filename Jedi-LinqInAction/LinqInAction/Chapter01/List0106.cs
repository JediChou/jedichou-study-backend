namespace LinqInAction.Chapter01
{
    using System.Collections.Generic;
    using System.Linq;

    public class List0106
    {
        /// <summary>
        /// 代码清单1-6 C#版本的Hello Linq
        /// </summary>
        /// <returns>筛选结果</returns>
        public List<string> HelloLinq()
        {
            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };
            var shortWords =
                from word in words
                where word.Length <= 5
                select word;
            return shortWords.ToList<string>();
        }
    }
}
