using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace IdeaValidation.Web.Models
{
    public class RequestParameters
    {
        /// <summary>
        /// User enters main keyword or term for analysis
        /// </summary>
        [Display(Name = "Keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// List of countries to perform analysis
        /// </summary>
        public IEnumerable<string> Countries { get; set; }

        /// <summary>
        /// List of languages to perform analysis
        /// </summary>
        public IEnumerable<string> Languages { get; set; }

        /// <summary>
        /// List of free style parameters for users
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }
    }
}