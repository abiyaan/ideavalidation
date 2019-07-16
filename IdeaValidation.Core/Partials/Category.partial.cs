using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using IdeaValidation.Core.ViewModel.Masters;
using System.Web.Mvc;

namespace IdeaValidation.Core.DataAccess
{
    public partial class Category
    {

        public static List<SelectListItem> GetParentDropDownList()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Categories
                                where p.IsActive && p.ParentID == null
                                select new SelectListItem
                                {
                                    Text = p.Name,
                                    Value = p.ID.ToString()
                                }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select Category",
                        Value = ""
                    });
                    return data;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static List<SelectListItem> GetDropDownList()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Categories
                                where p.IsActive
                                select new SelectListItem
                                {
                                    Text = p.Name,
                                    Value = p.ID.ToString()
                                }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select Category",
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


        public static List<CategoryViewViewModel> GetCategoryViews()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Categories
                                select new CategoryViewViewModel
                                {
                                    ID = p.ID,
                                    Name = p.Name,
                                    ParentName = p.Parent.Name
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

        public static bool SaveCategory(CategoryCreateViewModel model)
        {
            try
            {
                var data = new Category()
                {
                    Name = model.Name,
                    ParentID = model.ParentID,
                    IsActive = true,
                    CreatedBy = model.CreatedBy,
                    CreatedDate = DateTime.UtcNow
                };
                using (var context = new IdeaValidationContext())
                {
                    context.Categories.Add(data);
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
                    var data = context.Categories.AsEnumerable().LastOrDefault();
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
