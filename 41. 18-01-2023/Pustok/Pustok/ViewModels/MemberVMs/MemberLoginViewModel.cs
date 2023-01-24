using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels.MemberVMs
{
	public class MemberLoginViewModel
	{
        [Required]
        [StringLength(maximumLength: 30)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
