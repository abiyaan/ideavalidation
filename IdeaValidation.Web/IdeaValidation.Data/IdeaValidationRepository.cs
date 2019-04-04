using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaValidation.Data
{
    public class IdeaValidationRepository : IIdeaValidationRepository, IDisposable
    {
        private bool disposed = false;

        private ideavalidationConnection context;

        #region Constructor

        public IdeaValidationRepository(ideavalidationConnection context)
        {
            this.context = context;
        }

        #endregion

        #region IDisposable Implementation

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IIdeaValidationRepository Implementation

        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return this.context.Countries.ToList();
        }

        public IEnumerable<Company> GetCompaniesByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompaniesByCountry(string countryCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompaniesByCountryAndCategory(int categoryId, string countryCode)
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyByNumber(string companyNumber)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
