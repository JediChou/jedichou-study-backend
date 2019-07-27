using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace datagrid_demo_withmvc4.Controllers
{
    public class StoreController : Controller
    {
        public string Index(string id)
        {
            // accept request param
            ViewBag.id = id;
            
            // creeate a list 
            var user1 = new User { Name = "Yang", Email = "Yang@163.com", Date = "2013" };
            var user2 = new User { Name = "Ray", Email = "Ray@163.com", Date = "2008" };
            var user3 = new User { Name = "Jedi", Email = "Jedi@163.com", Date = "2007" };
            var templist = new List<User> {user1, user2, user3};

            // create a object, and ready to json serialize
            var userlist = new UserList {Total=templist.Count,Rows = templist};
			
			// 面向对象的分页
			// var queryResultPage = queryResult
            //    .Skip(numberOfObjectsPerPage * pageNumber)
            //    .Take(numberOfObjectsPerPage);
            
            // return object serialize result
            return JsonConvert.SerializeObject(userlist) + " | " + id;
        }

		// 
        public new class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Date { get; set; }
        }

        public new class UserList
        {
            public int Total { get; set; }
            public List<User> Rows { get; set; }
        }
    }
}
