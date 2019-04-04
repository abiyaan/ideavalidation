using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaValidation.Data
{
    public interface IIdeaValidationRepository : IDisposable
    {
        /// <summary>
        /// Get all companies from the database
        /// </summary>
        /// <returns>List of all companies</returns>
        IEnumerable<Company> GetAllCompanies();

        /// <summary>
        /// Gets the company details by company number
        /// </summary>
        /// <param name="companyNumber"></param>
        /// <returns>Company that matches the number</returns>
        Company GetCompanyByNumber(string companyNumber);

        /// <summary>
        /// Get all countries from database
        /// </summary>
        /// <returns>List of countries</returns>
        IEnumerable<Country> GetAllCountries();


        /// <summary>
        /// Get all categories from database
        /// </summary>
        /// <returns>List of categories</returns>
        IEnumerable<Category> GetAllCategories();

        /// <summary>
        /// Get all companies by Country
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns>List of companies by Country</returns>
        IEnumerable<Company> GetCompaniesByCountry(string countryCode);

        /// <summary>
        /// Get all companies by category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>List of compaies by category</returns>
        IEnumerable<Company> GetCompaniesByCategory(int categoryId);

        /// <summary>
        /// Get all companies by country and category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="countryCode"></param>
        /// <returns>List of companies by country and category</returns>
        IEnumerable<Company> GetCompaniesByCountryAndCategory(int categoryId, string countryCode);
    }
}
