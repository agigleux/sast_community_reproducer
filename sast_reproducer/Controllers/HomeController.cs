using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace sast_reproducer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test(string unsafeSql)
        {
            new Regex(unsafeSql);
        
            var service = new DummyService();

            service.execute("select * from [sys].[all_views] where name='" + unsafeSql + "'");

            return this.PartialView("Index");
        }
    }
}
