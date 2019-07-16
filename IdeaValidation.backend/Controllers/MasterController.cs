using Microsoft.AspNetCore.Mvc;

namespace IdeaValidation.backend.Controllers
{
    public class MasterController : Controller
    {
        #region Category
        public IActionResult CategoryCreate()
        {
            CategoryCreateViewModel data = new CategoryCreateViewModel();
            return PartialView("~/Views/Master/Category/Create.cshtml", data);
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryCreateViewModel model)
        {
            model.CreatedBy = "admin";
            model.CreateCategory();
            ViewBag.Message = "Saved Successfully";
            return View("../Home/Index");
        }

        public IActionResult CategoryView()
        {
            var data = CategoryViewViewModel.GetCategoriesView();
            return PartialView("~/Views/Master/Category/View.cshtml", data);
        }
        #endregion

        #region "Business Types"
        public IActionResult BusinessTypeCreate()
        {
            return PartialView("~/Views/Master/BusinessType/Create.cshtml");
        }

        [HttpPost]
        public IActionResult BusinessTypeCreate(BusinessTypeCreateViewModel model)
        {
            model.CreatedBy = "admin";
            model.CreateBusinessType();
            ViewBag.Message = "Saved Successfully";
            return View("../Home/Index");
        }
        #endregion

        #region "Address Type"
        public IActionResult AddressTypeCreate()
        {
            return PartialView("~/Views/Master/AddressType/Create.cshtml");
        }

        [HttpPost]
        public IActionResult AddressTypeCreate(AddressTypeCreateViewModel model)
        {
            model.CreatedBy = "admin";
            model.CreateAddressType();
            ViewBag.Message = "Saved Successfully";
            return View("../Home/Index");
        }

        #endregion

        public IActionResult CountryCreate()
        {
            return PartialView("~/Views/Master/Country/Create.cshtml");
        }

        public IActionResult StateCreate()
        {
            return PartialView("~/Views/Master/State/Create.cshtml");
        }

        public IActionResult CityCreate()
        {
            return PartialView("~/Views/Master/City/Create.cshtml");
        }
    }
}