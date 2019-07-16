using IdeaValidation.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaValidation.Core.ViewModel.Masters
{
    public class BusinessTypeViewModel
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public string TypeCode{ get; set; }

        public static List<BusinessTypeViewModel> GetBusinessTypeView()
        {
            try
            {
                return BusinessType.GetBusinessTypeViews();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class BusinessTypeCreateViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }
        public bool IsActive => true;
        public string CreatedBy { get; set; }
        public string LastRecord { get; set; }
        public BusinessTypeCreateViewModel()
        {
            LastRecord = "Last record saved : " + BusinessType.LastRecordSaved();
        }

        public bool CreateBusinessType()
        {
            try
            {
                BusinessType.SaveBusinessType(this);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
