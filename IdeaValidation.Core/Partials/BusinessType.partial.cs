using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Linq;
using System.Linq.Expressions;
namespace IdeaValidation.Core.DataAccess
{
    public partial class BusinessType
    {
        public static List<SelectListItem> GetDropDownList()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.BusinessTypes
                                where p.IsActive
                                select new SelectListItem
                                {
                                    Text = p.TypeName,
                                    Value = p.ID.ToString()
                                }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select Business Type",
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

        public static List<BusinessTypeViewModel> GetBusinessTypeViews()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.BusinessTypes
                                select new BusinessTypeViewModel
                                {
                                    ID = p.ID,
                                    TypeCode = p.TypeCode,
                                    TypeName = p.TypeName
                                }).ToList();
                    //var retValue = data.Select(r => new CategoryViewViewModel()
                    //{
                    //    Id = r.ID,
                    //    Name = r.Name,  
                    //    ParentName = r.Parent == null ? "-" : r.Parent.Name
                    //}).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveBusinessType(BusinessTypeCreateViewModel model)
        {
            try
            {
                var data = new BusinessType()
                {
                    TypeName = model.TypeName,
                    TypeCode = model.TypeCode,
                    IsActive = true,
                    CreatedBy = model.CreatedBy,
                    CreatedDate = DateTime.UtcNow
                };
                using (var context = new IdeaValidationContext())
                {
                    context.BusinessTypes.Add(data);
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
                    var data = context.BusinessTypes.AsEnumerable().LastOrDefault();
                    if (data == null)
                    {
                        return "none";
                    }
                    else
                    {
                        return data.TypeName;
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
