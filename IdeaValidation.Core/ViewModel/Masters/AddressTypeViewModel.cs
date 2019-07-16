using IdeaValidation.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class AddressTypeViewModel
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }

        public static List<AddressTypeViewModel> GetAddressTypeView()
        {
            try
            {
                return AddressType.GetAddressTypeViews();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class AddressTypeCreateViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string LastRecord { get; set; }
        public AddressTypeCreateViewModel()
        {
            LastRecord = "Last record saved : " + AddressType.LastRecordSaved();
        }

        public bool CreateAddressType()
        {
            try
            {
                AddressType.SaveAddressType(this);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
