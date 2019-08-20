namespace LinqInAction.Chapter01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class List0109
    {
        /// <summary>
        /// 代码清单1-9 C#版本的Hello LINQ，增加了分组和排序功能(HelloLinqWithGroupingAndSorting)
        /// </summary>
        public object HelloLinqWithGroupingAndSorting()
        {
            string[] words = { "hello", "woonderful", "linq", "beautiful", "world" };

            var groups =
                from word in words
                orderby word ascending
                group word by word.Length into lengthGroups
                orderby lengthGroups.Key descending
                select new { Length = lengthGroups.Key, words = lengthGroups };

            var result = groups.ToDictionary();

            return result;
        }
    }
}
