using System.ComponentModel.DataAnnotations;

namespace ABP_VUE.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}