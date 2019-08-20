namespace LinqInAction.Chapter01
{
    using System.Collections.Generic;
    using System.Linq;

    public class List0108
    {
        public List<string> OldSchoolHello()
        {
            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };
            List<string> result = new List<string>();

            foreach (var word in words)
                if (word.Length <= 5)
                    result.Add(word);

            return result;
        }
    }
}
