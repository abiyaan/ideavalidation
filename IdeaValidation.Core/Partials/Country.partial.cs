using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web.Mvc;

namespace IdeaValidation.Core.DataAccess
{
    public partial class Country
    {
        public static List<SelectListItem> GetDropDownList()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Countries
                                where p.IsActive
                                orderby p.Name
                                select new SelectListItem
                                {
                                    Text = p.Name,
                                    Value = p.ID.ToString()
                                }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select Country",
                        Value = ""
                    });
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CountryViewModel> GetCountriesViews()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Countries
                                orderby p.Name
                                select new CountryViewModel
                                {
                                    ID = p.ID,
                                    Code = p.Code,
                                    CurrencyCode = p.CurrencyCode,
                                    CurrencyName = p.CurrencyName,
                                    Name = p.Name
                                }).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveCountry(CountryCreateViewModel model)
        {
            try
            {
                var data = new Country()
                {
                    Name = model.Name,
                    CurrencyName = model.CurrencyName,
                    CurrencyCode = model.CurrencyCode,
                    Code = model.Code,
                    IsActive = model.IsActive,
                    CreatedBy = model.CreatedBy,
                    CreatedDate = DateTime.UtcNow
                };
                using (var context = new IdeaValidationContext())
                {
                    context.Countries.Add(data);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string LastRecordSaved()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = context.Countries.AsEnumerable().LastOrDefault();
                    if (data == null)
                    {
                        return "none";
                    }
                    else
                    {
                        return data.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
