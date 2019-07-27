using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStudy
{
    public partial class Linq100
    {
        #region Projection Operators

        /// <summary>
        /// Linq100-exmaple 6
        /// This sample uses select to produce a sequence of ints one 
        /// higher than those in an existing array of ints.
        /// </summary>
        /// <returns></returns>
        public static int[] Linq6()
        {
            int[] nums = {0, 1, 2, 3, 4, 5};
            var query =
                from num in nums
                select num + 1;
            return query.ToArray();
        }

        /// <summary>
        /// Linq100-exmaple 7
        /// This sample uses select to return a sequence of just the
        /// names of a list of products.
        /// </summary>
        /// <returns></returns>
        public static string[] Linq7()
        {
            var products = new List<Product>
                {
                    new Product("Beer", 20, 30),
                    new Product("LaoGanMa", 0, 20),
                    new Product("Pen", 0, 5)
                };

            var query =
                from product in products
                select product.Name;

            return query.ToArray();
        }

        #endregion
    }
}
