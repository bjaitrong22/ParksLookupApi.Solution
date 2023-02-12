using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.ResourceModels
{
  public class User
  {
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email {get; set; }


  }
}