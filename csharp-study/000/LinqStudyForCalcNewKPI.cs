using System.Collections.Generic;
using System.Linq;

namespace LinqStudy
{
    public class LinqStudy
    {
        public static string[] LinqStudy1()
        {
            var names = new[] {"Jedi", "Becky", "Kiwi"};
            var query =
                from s in names
                where s.Length <= 4
                orderby s
                select s;
            return query.ToArray();
        }

        public static string[] LinqStudy2()
        {
            var names = new[] { "jedi", "becky", "kiwi" };
            var query =
                from s in names
                where s.Length <= 4
                orderby s
                select s.ToUpper();
            return query.ToArray();
        }

        public static int LinqStudy3()
        {
            var ints = new[] {1, 2, 3};
            var result =
                from s in ints
                where s <= 2
                where s > 1 
                select s;
            return result.Sum();
        }

        public static int LinqStudy4()
        {
            var dict = new Dictionary<string, int>();
            dict["A"] = 12;
            dict["B"] = 13;
            dict["C"] = 14;

            var result =
                from elt in dict
                where elt.Key != "A"
                select elt.Value;

            return result.Sum();
        }

        public class Employee
        {
            public string Name { get; set; }
            public string ProGroup { get; set; }
            public double Profit { get; set; }
            public bool ProLeader { get; set; }
        }

        public static double LinqStudy5()
        {
            var emplist = new List<Employee>
                {
                    new Employee{Name = "Jedi", ProGroup = "302", ProLeader = true, Profit = 10000},
                    new Employee{Name = "Becky", ProGroup = "302", ProLeader = false, Profit = 6000},
                    new Employee{Name = "Kiwi", ProGroup = "302", ProLeader = false, Profit = 0},
                    new Employee{Name = "XXX", ProGroup = "301", ProLeader = true, Profit = 5000},
                    new Employee{Name = "YYY", ProGroup = "301", ProLeader = false, Profit = 7000},
                    new Employee{Name = "ZZZ", ProGroup = "301", ProLeader = false, Profit = 0},
                };

            var empdict = emplist.ToDictionary(emp => emp.Name);
            var query =
                from empKeyValue in empdict
                where empKeyValue.Value.ProGroup == "302"
                where empKeyValue.Value.ProLeader
                select empKeyValue.Value.Profit;

            return query.Sum();
        }

        public static List<Employee> LinqStudy6()
        {
            var emplist = new List<Employee>
                {
                    new Employee{Name = "Jedi", ProGroup = "302", ProLeader = true, Profit = 10000},
                    new Employee{Name = "Becky", ProGroup = "302", ProLeader = false, Profit = 6000},
                    new Employee{Name = "Kiwi", ProGroup = "302", ProLeader = false, Profit = 0},
                    new Employee{Name = "XXX", ProGroup = "301", ProLeader = true, Profit = 5000},
                    new Employee{Name = "YYY", ProGroup = "301", ProLeader = false, Profit = 7000},
                    new Employee{Name = "ZZZ", ProGroup = "301", ProLeader = false, Profit = 0},
                };
            var empdict = emplist.ToDictionary(emp => emp.Name);
            return empdict.Values.ToList();
        }

        public static double LinqStudy7()
        {
            var emplist = new List<Employee>
                {
                    new Employee{Name = "Jedi", ProGroup = "302", ProLeader = true, Profit = 10000},
                    new Employee{Name = "Becky", ProGroup = "302", ProLeader = false, Profit = 6000},
                    new Employee{Name = "Kiwi", ProGroup = "302", ProLeader = false, Profit = 0},
                    new Employee{Name = "XXX", ProGroup = "301", ProLeader = true, Profit = 5000},
                    new Employee{Name = "YYY", ProGroup = "301", ProLeader = false, Profit = 7000},
                    new Employee{Name = "ZZZ", ProGroup = "301", ProLeader = false, Profit = 0},
                };

            var empdict = emplist.ToDictionary(emp => emp.Name);

            foreach (var empKeyValue in empdict)
            {
                if (!empKeyValue.Value.ProLeader) continue;

                var list = empdict.Values.ToList();
                var selfprofit = empKeyValue.Value.Profit;
                var name = empKeyValue.Key;
                var groupid = empKeyValue.Value.ProGroup;
                var query =
                    from member in list
                    where member.ProGroup == groupid
                    select member.Profit;
                var groupprofit = query.Sum();
                empdict[name].Profit = selfprofit * 0.5 + groupprofit * 0.5;
            }

            return empdict["Jedi"].Profit;
        }
    }
}
