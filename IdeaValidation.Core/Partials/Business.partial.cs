using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaValidation.Core.DataAccess
{
    public partial class Business
    {
        public static List<BusinessTableViewModel> GetBusinessList(int categoryId)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Businesses
                                where p.CategoryID.Value.Equals(categoryId)
                                select new BusinessTableViewModel
                                {
                                    ID = p.ID,
                                    BusinessName = p.BusinessName,
                                    BusinessType = p.BusinessType,
                                    CategoryID = p.CategoryID,
                                    Country = p.RegisteredCountry,
                                    RegistrationNo = p.RegistrationNumber,
                                    YearOfIncorporation = p.YearOfIncorporation
                                }).ToList();
                    return data;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static long SaveBusiness(BusinessCreateViewModel model)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = new Business()
                    {
                        BusinessName = model.BusinessName,
                        BusinessType = model.BusinessType,
                        CategoryID = model.CategoryID,
                        CategoryName = model.CategoryName,
                        CreatedBy = model.CreatedBy,
                        CreatedDate = DateTime.UtcNow,
                        DataSourceName = model.DataSourceName,
                        EmailID = model.EmailID,
                        IncorporationDate = model.IncorporationDate,
                        YearOfIncorporation = model.YearOfIncorporation,
                        NoOfEmployees = model.NoOfEmployees,
                        RegisteredCountry = model.RegisteredCountry,
                        RegisteredCountryID = model.RegisteredCountryID,
                        RegisteredProvince = model.RegisteredProvince,
                        RegisteredProvinceID = model.RegisteredProvinceID,
                        RegistrationNumber = model.RegistrationNumber,
                        Status = model.Status,
                        Tags = model.Tags,
                        Website = model.Website
                    };
                    context.Businesses.Add(data);
                    context.SaveChanges();
                    return data.ID;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
