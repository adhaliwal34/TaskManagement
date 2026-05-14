using System.ComponentModel.DataAnnotations;

namespace TaskStream.Web.Models.Accounts;

public class AccountLoginViewModel
{
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Password { get; set; }
    public string? ReturnUrl { get; set; }
    public bool RememberMe  { get; set; }
}

