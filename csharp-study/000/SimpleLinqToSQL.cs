using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SimpleLinqToSQL
{
    static class HelloLinqToSql
    {
        [Table(Name = "Contacts")]
        class Contact
        {
            [Column(IsPrimaryKey = true)]
            public int ContactsId { get; set; }

            [Column(Name = "ContactName")]
            public string Name { get; set; }

            [Column]
            public string City { get; set; }
        }

        static void Main()
        {
            try
            {
                const string dbConnectStr = 
                    "Data Source=localhost, 1433;" +
                    "User ID= sa; " + 
                    "Password = samsung1s;" +
                    "persist security info=False;" +
                    "initial catalog=northwind;";

                // const string path = @"D:\NORTHWND.MDF";
                var db = new DataContext(dbConnectStr);

                var contacts =
                    from contact in db.GetTable<Contact>()
                    select contact;

                foreach (var contact in contacts)
                    Console.WriteLine("Bonjour " + contact.Name + ". You from " + contact.City);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}


