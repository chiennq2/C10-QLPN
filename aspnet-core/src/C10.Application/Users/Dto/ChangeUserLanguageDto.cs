using System.ComponentModel.DataAnnotations;

namespace C10.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}