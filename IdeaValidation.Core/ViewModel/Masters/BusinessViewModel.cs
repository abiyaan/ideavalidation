using IdeaValidation.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class BusinessViewViewModel
    {
        public BusinessViewViewModel()
        {
            CategoryList = Category.GetDropDownList();
            if (CategoryList.Count > 1)
                BusinessList = BusinessTableViewModel.GetListByCategoryID(int.Parse(CategoryList[1].Value));
            else
                BusinessList = new List<BusinessTableViewModel>();
        }
        public List<SelectListItem> CategoryList { get; set; }
        public List<BusinessTableViewModel> BusinessList { get; set; }
    }

    public class BusinessTableViewModel
    {
        public long ID { get; set; }
        public string BusinessName { get; set; }
        public int? CategoryID { get; set; }
        public string RegistrationNo { get; set; }
        public int? YearOfIncorporation { get; set; }
        public string Country { get; set; }
        public string BusinessType { get; set; }

        public static List<BusinessTableViewModel> GetListByCategoryID(int categoryID)
        {
            return Business.GetBusinessList(categoryID);
        }
    }

    public class BusinessCreateViewModel
    {
        public BusinessCreateViewModel()
        {
            CountryList = Country.GetDropDownList();
            StateList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Select State",
                    Value = ""
                }
            };
            BusinessTypeList = DataAccess.BusinessType.GetDropDownList();
            CategoryList = Category.GetDropDownList();
            StatusList = BusinessStatus.GetDropDownList();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(500)]
        public string BusinessName { get; set; }

        [StringLength(100)]
        public string RegistrationNumber { get; set; }

        [StringLength(300)]
        public string RegisteredProvince { get; set; }

        public int? RegisteredProvinceID { get; set; }

        public List<SelectListItem> StateList { get; set; }

        [StringLength(200)]
        public string RegisteredCountry { get; set; }

        public int? RegisteredCountryID { get; set; }

        public List<SelectListItem> CountryList { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [StringLength(200)]
        public string EmailID { get; set; }

        public int? YearOfIncorporation { get; set; }

        public DateTime? IncorporationDate { get; set; }

        [StringLength(10)]
        public string BusinessType { get; set; }
        public int BusinessTypeID { get; set; }
        public List<SelectListItem> BusinessTypeList { get; set; }

        [StringLength(100)]
        public string Status { get; set; }
        public List<SelectListItem> StatusList { get; set; }


        [StringLength(500)]
        public string DataSourceName { get; set; }

        [StringLength(4000)]
        public string Tags { get; set; }

        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<SelectListItem> CategoryList { get; set; }

        public string NoOfEmployees { get; set; }

        public string LastRecord { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public long SaveBusinessData()
        {
            try
            {
                this.ID = Business.SaveBusiness(this);
                return this.ID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
