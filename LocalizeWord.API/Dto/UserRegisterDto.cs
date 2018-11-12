using System.ComponentModel.DataAnnotations;

namespace LocalizeWord.API.Dto
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength=8, ErrorMessage="You must specify password between 8 and 16 characteres")]
        public string Password { get; set; }
    }
}