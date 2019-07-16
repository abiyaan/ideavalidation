#region Using

using System.ComponentModel.DataAnnotations;

#endregion

namespace IdeaValidation.backend.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
