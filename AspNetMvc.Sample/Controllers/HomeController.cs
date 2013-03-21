using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> listUrls = new List<string>();
            listUrls.Add("www.google.com");
            listUrls.Add("www.bing.com");
            listUrls.Add("www.yahoo.com");
            listUrls.Add("www.msdn.com");
            ViewBag.Urls = listUrls;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
