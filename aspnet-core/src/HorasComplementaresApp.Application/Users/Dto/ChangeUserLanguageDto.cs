using System.ComponentModel.DataAnnotations;

namespace HorasComplementaresApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}