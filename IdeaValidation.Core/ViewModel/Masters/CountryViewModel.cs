using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using IdeaValidation.Core.DataAccess;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class CountryViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }

        public static List<CountryViewModel> GetCountriesView()
        {
            try
            {
                return Country.GetCountriesViews();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }

    public class CountryCreateViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string LastRecord { get; set; }
        public CountryCreateViewModel()
        {
            LastRecord = "Last record saved : " + Country.LastRecordSaved();
        }

        public bool CreateCountry()
        {
            try
            {
                Country.SaveCountry(this);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
