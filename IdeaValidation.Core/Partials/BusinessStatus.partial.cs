using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdeaValidation.Core.DataAccess    
{
    public partial class BusinessStatus
    {

        public static List<SelectListItem> GetDropDownList()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.BusinessStatuses
                                where p.IsActive
                                orderby p.Status
                                select new SelectListItem
                                {
                                    Text = p.Status,
                                    Value = p.ID.ToString()
                                }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select Status",
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
    }
}
