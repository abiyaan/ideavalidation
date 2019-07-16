#region Using

using System.ComponentModel.DataAnnotations;

#endregion

namespace IdeaValidation.backend.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
