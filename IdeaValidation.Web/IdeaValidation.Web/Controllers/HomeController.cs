using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompaniesHouse;
using CompaniesHouse.Request;
using System.Threading.Tasks;
using CompaniesHouse.Response.Search;
using System.Net;
using System.IO;
using CompaniesHouse.Response.CompanyProfile;
using System.Web.Script.Serialization;
using IdeaValidation.Data;
using Newtonsoft.Json;
//using Newtonsoft.Json;

namespace IdeaValidation.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.JsonData = "";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}