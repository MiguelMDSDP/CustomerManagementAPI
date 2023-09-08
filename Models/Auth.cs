using System.ComponentModel.DataAnnotations;

namespace CustomerManagementAPI.Models;

public class LoginRequest
{
  [Required(ErrorMessage = "Username is required.")]
  public string Username { get; set; }

  [Required(ErrorMessage = "Password is required.")]
  public string Password { get; set; }

  public LoginRequest()
  {
    Username = "";
    Password = "";
  }
}
