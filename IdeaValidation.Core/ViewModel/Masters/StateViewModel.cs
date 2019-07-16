using IdeaValidation.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public partial class StateViewViewModel
    {
        public StateViewViewModel()
        {
            CountryList = Country.GetDropDownList();
            StateList = State.GetStateViews();
        }

        public List<SelectListItem> CountryList { get; set; }
        
        public List<StateTableViewModel> StateList { get; set; }

        public static List<SelectListItem> GetStateListByCountryID(int CountryID)
        {
            return State.GetStateListByCountryID(CountryID);
        }
    }

    public class StateTableViewModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public int CountryID { get; set; }
    }

    public class StateCreateViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public int CountryID { get; set; }
        public List<SelectListItem> CountryList { get; set; }
        public string CreatedBy { get; set; }
        public string LastRecord { get; set; }
        public StateCreateViewModel()
        {
            CountryList =  Country.GetDropDownList();
            LastRecord = "Last record saved : " + State.LastRecordSaved();
        }

        public bool CreateState()
        {
            try
            {
                State.SaveState(this);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
