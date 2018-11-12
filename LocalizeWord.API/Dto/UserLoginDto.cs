using System.ComponentModel.DataAnnotations;

namespace LocalizeWord.API.Dto
{
    public class UserLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}