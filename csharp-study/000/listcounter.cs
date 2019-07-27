using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace ConsoleApplicationPerfmon
{
    class Program
    {
        /*
         To get a performance counter, we need:
         1.Machine 
         2.Category 
         3.Instance 
         4.Counter 
         
         NOTE:There are performance counters that did not have any instance.So when retrieve counters we using these 2 methods:
            a.PerformanceCounterCategory.GetCounters();
            b.PerformanceCounterCategory.GetCounters(string instanceName);
         */
        static void Main(string[] args)
        {
            //MachineName
            string machineName = System.Environment.MachineName;
            
            //Get all categories
            PerformanceCounterCategory[] categories = PerformanceCounterCategory.GetCategories(machineName);
            
            //Sort categories by name
            IOrderedEnumerable<PerformanceCounterCategory> orderedList = from category in categories
                                                                         orderby category.CategoryName
                                                                         select category;
            categories = orderedList.ToArray<PerformanceCounterCategory>();
            
            
            if (categories != null && categories.Count<PerformanceCounterCategory>() > 0)
            {
                //Get all instances
                string[] instanceNames = categories[0].GetInstanceNames();

                //If this category DOES contain instance, get counters
                if (instanceNames!=null && instanceNames.Count<string>() > 0)
                {
                    PerformanceCounter[] counters = categories[0].GetCounters(instanceNames[0]);
                }

                //If this category DOES NOT contain any instance, get counters
                else
                {
                    PerformanceCounter[] counters = categories[0].GetCounters();
                }
            }

			foreach(var counter in categories)
				Console.WriteLine(counter);
        }
    }
}
