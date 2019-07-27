using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace LBPEMvc.Web.Controllers
{
    public class GetJsonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTempResult(int page, int rows)
        {
            // accept datagrid request
            ViewData["page"] = page;
            ViewData["rows"] = rows;

            // create a simulate data
            var list = Enumerable.Range(1, 50);
            var result = list.Select(index => new
            {
                username = "user" + index, 
                email = "user" + index + "@foxconn.com", 
                date = Convert.ToString(index),
                age = index + 20
            }).ToList();
            
            var resultpage = result
                .Skip(rows * (page - 1))
                .Take(rows);

            var tempresult = new { total = result.Count, rows = resultpage.ToList() };
            return Json(tempresult, JsonRequestBehavior.AllowGet);
        }
    }
}
