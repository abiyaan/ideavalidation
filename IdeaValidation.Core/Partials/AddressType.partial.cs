using IdeaValidation.Core.ViewModel.Masters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IdeaValidation.Core.DataAccess
{
    public partial class AddressType
    {
        public static List<AddressTypeViewModel> GetAddressTypeViews()
        {
            try
            {
                using (var context = new IdeaValidationContext())
                {
                    var data = (from p in context.AddressTypes
                                select new AddressTypeViewModel
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

        public static bool SaveAddressType(AddressTypeCreateViewModel model)
        {
            try
            {
                var data = new AddressType()
                {
                    TypeName = model.TypeName,
                    TypeCode = model.TypeCode,
                    IsActive = model.IsActive,
                    CreatedBy = model.CreatedBy,
                    CreatedDate = DateTime.UtcNow
                };
                using (var context = new IdeaValidationContext())
                {
                    context.AddressTypes.Add(data);
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
                    var data = context.AddressTypes.AsEnumerable().LastOrDefault();
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
