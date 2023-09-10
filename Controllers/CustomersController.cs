using Microsoft.AspNetCore.Mvc;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Controllers
{
  [ApiController]
  [Route("api/customers")]
  public class CustomerController : ControllerBase
  {
    private readonly List<Customer> _customers = new()
    {
      new() { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", IsActive = true },
      new() { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", IsActive = true },
      new() { Id = 3, FirstName = "Michael", LastName = "Johnson", Email = "michael@example.com", IsActive = true },
      new() { Id = 4, FirstName = "Emily", LastName = "Brown", Email = "emily@example.com", IsActive = true },
      new() { Id = 5, FirstName = "William", LastName = "Taylor", Email = "william@example.com", IsActive = true },
      new() { Id = 6, FirstName = "Olivia", LastName = "Davis", Email = "olivia@example.com", IsActive = true },
      new() { Id = 7, FirstName = "James", LastName = "Wilson", Email = "james@example.com", IsActive = true },
      new() { Id = 8, FirstName = "Emma", LastName = "Anderson", Email = "emma@example.com", IsActive = true },
      new() { Id = 9, FirstName = "Benjamin", LastName = "Moore", Email = "benjamin@example.com", IsActive = true },
      new() { Id = 10, FirstName = "Ava", LastName = "Lee", Email = "ava@example.com", IsActive = true }
    };

    [HttpGet]
    public IActionResult GetCustomers()
    {
      return Ok(_customers);
    }

    [HttpGet("{id}")]
    public IActionResult GetCustomerById(int id)
    {
      var customer = _customers.FirstOrDefault(c => c.Id == id);
      if (customer == null)
      {
        return NotFound();
      }
      return Ok(customer);
    }

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] Customer customer)
    {
      if (customer == null)
      {
        return BadRequest("Invalid customer data.");
      }

      customer.Id = _customers.Count + 1;
      _customers.Add(customer);

      return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCustomer(int id, [FromBody] Customer updatedCustomer)
    {
      if (updatedCustomer == null)
      {
        return BadRequest("Invalid customer data.");
      }

      var existingCustomer = _customers.FirstOrDefault(c => c.Id == id);
      if (existingCustomer == null)
      {
        return NotFound();
      }

      existingCustomer.FirstName = updatedCustomer.FirstName;
      existingCustomer.LastName = updatedCustomer.LastName;
      existingCustomer.Email = updatedCustomer.Email;
      existingCustomer.IsActive = updatedCustomer.IsActive;

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
      var customerToDelete = _customers.FirstOrDefault(c => c.Id == id);
      if (customerToDelete == null)
      {
        return NotFound();
      }

      _customers.Remove(customerToDelete);

      return NoContent();
    }
  }
}
