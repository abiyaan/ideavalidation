using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaValidation.Core.DataAccess    
{
    public partial class City
    {
        public static List<CityTableViewModel> GetCityByStateID(long stateID)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.Cities
                                where p.StateID.Value.Equals(stateID)
                                select new CityTableViewModel
                                {
                                    ID = p.ID,
                                    Name = p.Name,
                                    CityCode = p.CityCode,
                                    StateID = p.StateID.Value
                                }).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveCity(CityCreateViewModel model)
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = new City()
                    {
                        Name = model.Name,
                        StateID = model.StateID,
                        IsActive = true,
                        CreatedBy = model.CreatedBy,
                        CreatedDate = DateTime.UtcNow
                    };
                    context.Cities.Add(data);
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
                    var data = context.Cities.AsEnumerable().LastOrDefault();
                    if(data == null)
                    {
                        return "none";
                    }
                    else
                    {
                        return data.Name + " (State : " + data.State.Name + ")";
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
