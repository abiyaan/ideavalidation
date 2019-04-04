using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdeaValidation.Web.Models;
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
        CompaniesHouseSettings CHSettings = new CompaniesHouseSettings("dJ7lfN4d58OcauxMLZAW06g3IMu2asAYDr0w__Kk");

        public ActionResult Index()
        {
            var model = new RequestParameters();
            var ideaValidationRepository = new IdeaValidationRepository(new ideavalidationConnection());
            model.Countries = ideaValidationRepository.GetAllCountries();
            model.Languages = new List<string> {"", "English", "Arabic", "Hindi", "Chinese"};

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RequestParameters model)
        {
            model = new RequestParameters();
            model.Countries = null;
            model.Languages = new List<string> { "", "English", "Arabic", "Hindi", "Chinese" };

            // not doing much for now.
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.JsonData = "";
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> About(string companyNumber)
        {
            ViewBag.Message = "Your application description page.";

            var profileData = await CompanyProfileData(companyNumber);
            ViewBag.JsonData = JsonPrettify(new JavaScriptSerializer().Serialize(profileData));

            return View();
        }

        private async Task<CompanyProfile> CompanyProfileData(string companyNumber)
        {
            using (var client = new CompaniesHouseClient(CHSettings))
            {
                var profile = await client.GetCompanyProfileAsync(companyNumber);

                return profile.Data;
            }
        }

        private async Task<SearchItem[]> SearchCHData()
        {
            using (var client = new CompaniesHouseClient(CHSettings))
            {
                var request = new SearchRequest()
                {
                    Query = "Cloth",
                    StartIndex = 10,
                    ItemsPerPage = 10
                };

                var result = await client.SearchAllAsync(request);

                return result.Data.Items;
            }
        }

        public static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}