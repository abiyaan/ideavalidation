using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IdeaValidation.Core.DataAccess    
{
    public partial class State
    {
        public static List<StateTableViewModel> GetStateViews()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.States
                                select new StateTableViewModel
                                {
                                    ID = p.ID,
                                    Name = p.Name,
                                    StateCode = p.StateCode,
                                    CountryID = p.CountryID
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

        public static List<SelectListItem> GetStateListByCountryID(int CountryID)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = context.States
                        .Where(r => r.CountryID.Equals(CountryID))
                        .Select(p => new SelectListItem
                        {
                            Text = p.Name,
                            Value = p.ID.ToString()
                        }).ToList();
                    data.Insert(0, new SelectListItem()
                    {
                        Text = "Select State",
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

        public static bool SaveState(StateCreateViewModel model)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = new State()
                    {
                        Name = model.Name,
                        StateCode = model.StateCode,
                        CountryID = model.CountryID,
                        IsActive = true,
                        CreatedBy = model.CreatedBy,
                        CreatedDate = DateTime.UtcNow
                    };
                    context.States.Add(data);
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
                    var data = context.States.AsEnumerable().LastOrDefault();
                    if (data == null)
                    {
                        return "none";
                    }
                    else
                    {
                        return data.Name + " (Country : " + data.Country.Name + ")";
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
