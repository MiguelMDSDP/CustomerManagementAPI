using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IConfiguration _config;

    public AuthController(IConfiguration config)
    {
      _config = config;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest model)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest("Request malformed.");
      }

      if (model.Username == "admin" && model.Password == "admin")
      {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, "admin"),
        };

        var jwtKey = _config["Jwt:Key"];
        if (jwtKey == null) return StatusCode(StatusCodes.Status500InternalServerError);
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Issuer"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds);

        return Ok(new
        {
          username = model.Username,
          token = new JwtSecurityTokenHandler().WriteToken(token)
        });
      }
      else
      {
        return Unauthorized("Invalid credentials.");
      }
    }
  }
}
