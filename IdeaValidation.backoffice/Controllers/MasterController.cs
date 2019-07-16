using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using IdeaValidation.backoffice;
using IdeaValidation.Core.ViewModel.Masters;

namespace IdeaValidation.backend.Controllers
{
    public class MasterController : Controller
    {
        #region Category
        public ActionResult CategoryCreate()
        {
            CategoryCreateViewModel model = new CategoryCreateViewModel();
            return PartialView("~/Views/Master/Category/Create.cshtml", model);
        }

        [HttpPost]
        public JsonResult CategoryCreate(CategoryCreateViewModel model)
        {
            model.CreatedBy = Settings.CurrentUser;
            model.CreateCategory();
            //return View("../Home/Index");
            CategoryCreateViewModel data = new CategoryCreateViewModel();
            return new JsonResult() { Data = data.ParentCategory };
        }

        public ActionResult CategoryView()
        {
            var model = CategoryViewViewModel.GetCategoriesView();
            return PartialView("~/Views/Master/Category/View.cshtml", model);
        }
        #endregion

        #region "Business Types"
        public ActionResult BusinessTypeCreate()
        {
            var data = new BusinessTypeCreateViewModel();
            return PartialView("~/Views/Master/BusinessType/Create.cshtml", data);
        }

        [HttpPost]
        public ActionResult BusinessTypeCreate(BusinessTypeCreateViewModel model)
        {
            model.CreatedBy = Settings.CurrentUser;
            model.CreateBusinessType();
            //return View("../Home/Index");
            BusinessTypeCreateViewModel data = new BusinessTypeCreateViewModel();
            return new JsonResult() { Data = 1 };
        }

        public ActionResult BusinessTypeView()
        {
            var model = BusinessTypeViewModel.GetBusinessTypeView();
            return PartialView("~/Views/Master/BusinessType/View.cshtml", model);
        }
        #endregion

        #region "Address Type"
        public ActionResult AddressTypeCreate()
        {
            var data = new AddressTypeCreateViewModel();
            return PartialView("~/Views/Master/AddressType/Create.cshtml", data);
        }

        [HttpPost]
        public ActionResult AddressTypeCreate(AddressTypeCreateViewModel model)
        {
            model.CreatedBy = Settings.CurrentUser;
            model.CreateAddressType();
            //ViewBag.Message = "Saved Successfully";
            //return View("../Home/Index");
            //AddressTypeCreateViewModel data = new AddressTypeCreateViewModel();
            return new JsonResult() { Data = 1 };
        }

        public ActionResult AddressTypeView()
        {
            var model = AddressTypeViewModel.GetAddressTypeView();
            return PartialView("~/Views/Master/AddressType/View.cshtml", model);
        }
        #endregion

        #region "Country"
        public ActionResult CountryCreate()
        {
            var data = new CountryCreateViewModel();
            return PartialView("~/Views/Master/Country/Create.cshtml", data);
        }

        [HttpPost]
        public ActionResult CountryCreate(CountryCreateViewModel model)
        {
            model.CreatedBy = Settings.CurrentUser;
            model.IsActive = true;
            model.CreateCountry();
            //ViewBag.Message = "Saved Successfully";
            //return View("../Home/Index");
            //CountryCreateViewModel data = new CountryCreateViewModel();
            return new JsonResult() { Data = 1 };
        }

        public ActionResult CountryView()
        {
            var model = CountryViewModel.GetCountriesView();
            return PartialView("~/Views/Master/Country/View.cshtml", model);
        }
        #endregion "Country"

        #region "State"

        public ActionResult StateView()
        {
            var model = new  StateViewViewModel();
            return PartialView("~/Views/Master/State/View.cshtml", model);
        }

        public ActionResult StateCreate()
        {
            var model = new StateCreateViewModel();
            return PartialView("~/Views/Master/State/Create.cshtml", model);
        }

        [HttpPost]
        public ActionResult StateCreate(StateCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                model.CreatedBy = Settings.CurrentUser;
                model.CreateState();
                //ViewBag.Message = "Saved Successfully";
                //return View("../Home/Index");
                //CountryCreateViewModel data = new CountryCreateViewModel();
                return new JsonResult() { Data = 1 };
            }
            else
                return new JsonResult() { Data = 0};

        }

        public JsonResult GetStateByCountry(int countryId)
        {
            var data = StateViewViewModel.GetStateListByCountryID(countryId);
            return Json(new { Data = data }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region "City"
        public ActionResult CityCreate()
        {
            var model = new CityCreateViewModel();
            return PartialView("~/Views/Master/City/Create.cshtml", model);
        }

        [HttpPost]
        public ActionResult CityCreate(CityCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = Settings.CurrentUser;
                model.CreateCity();
                return new JsonResult() { Data = 1 };
            }
            else
                return new JsonResult() { Data = 0 };
        }

        public ActionResult CityView()
        {
            var model = new CityViewViewModel();
            return PartialView("~/Views/Master/City/View.cshtml", model);
        }
        #endregion

        #region "Business"

        public ActionResult BusinessCreate()
        {
            var data = new BusinessCreateViewModel();
            return PartialView("~/Views/Master/Business/Create.cshtml", data);
        }

        [HttpPost]
        public ActionResult BusinessCreate(BusinessCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                model.CreatedBy = Settings.CurrentUser;
                model.SaveBusinessData();
                return Json(new {Page = 1, Data = model.ID, msg = "Business added successfully"});
            }
            else
            {
                string errorMsg = "";
                foreach (var data in ModelState.ToList())
                {
                    if (ModelState[data.Key].Errors.Count > 0)
                        errorMsg += ModelState[data.Key].Errors[0].ErrorMessage + "<br/>";
                }
                return Json(new { Page = 1, Data = 0, msg = errorMsg });
            }
        }

        public ActionResult BusinessView()
        {
            var data = new BusinessViewViewModel();
            return PartialView("~/Views/Master/Business/View.cshtml", data);
        }

        public JsonResult GetCityByStateID(long stateID)
        {
            var data = CityTableViewModel.GetCityByStateID(stateID);
            return Json(new { Data = data }, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}