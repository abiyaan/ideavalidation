using IdeaValidation.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class CityViewViewModel
    {
        public CityViewViewModel()
        {
            CountryList = Country.GetDropDownList();
            if (CountryList.Count > 1)
                StateList = State.GetStateListByCountryID(int.Parse(CountryList[1].Value));
            else
            {
                StateList = new List<SelectListItem>()
                            {
                                new SelectListItem()
                                {
                                    Text = "Select State",
                                    Value = ""
                                }
                            };
            }
            if (StateList.Count > 1)
                CityList = CityTableViewModel.GetCityByStateID(long.Parse(StateList[1].Value));
            else
                CityList = new List<CityTableViewModel>();
        }

        public List<SelectListItem> CountryList { get; set; }

        public List<SelectListItem> StateList { get; set; }

        public List<CityTableViewModel> CityList { get; set; }
    }

    public class CityTableViewModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string CityCode { get; set; }

        public long StateID { get; set; }

        public static List<CityTableViewModel> GetCityByStateID(long stateID)
        {
            return City.GetCityByStateID(stateID);
        }
    }

    public class CityCreateViewModel
    {
        public CityCreateViewModel()
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

            LastRecord = "Last record saved : " + City.LastRecordSaved();
        }

        public long ID { get; set; }

        public string Name { get; set; }

        public string CityCode { get; set; }

        public long? StateID { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastRecord { get; set; }

        public List<SelectListItem> CountryList { get; set; }
        
        public List<SelectListItem> StateList { get; set; }

        public bool CreateCity()
        {
            try
            {
                City.SaveCity(this);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
