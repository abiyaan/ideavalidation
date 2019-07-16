using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using IdeaValidation.Core.DataAccess;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class CategoryViewViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }

        public static List<CategoryViewViewModel> GetCategoriesView()
        {
            try
            {
                return Category.GetCategoryViews();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }

    public class CategoryCreateViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public List<SelectListItem> ParentCategory { get; set; }
        public string CreatedBy { get; set; }
        public string LastRecord { get; set; }
        public CategoryCreateViewModel()
        {
            ParentCategory = Category.GetParentDropDownList();
            LastRecord = "Last record saved : " + Category.LastRecordSaved();
        }

        public bool CreateCategory()
        {
            try
            {
                Category.SaveCategory(this);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
