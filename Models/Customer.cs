using System.ComponentModel.DataAnnotations;

namespace CustomerManagementAPI.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "IsActive is required.")]
    public bool IsActive { get; set; }

    public Customer()
    {
      FirstName = "";
      LastName = "";
      Email = "";
    }
  }
}

