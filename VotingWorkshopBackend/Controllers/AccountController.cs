using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using VotingWorkshopBackend.Model;

namespace VotingWorkshopBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        public WssVotingWorkshopSystemContext dbContxext = new();

        [HttpPost("login")]
        public IActionResult Post([FromBody] LoginRequest loginRequest)
        {
            User? user = dbContxext.Users.FirstOrDefault(u => u.Username == loginRequest.Username);

            if (user == null)
            {
                return NotFound("Invalid Username");
            }

            var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginRequest.Password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return BadRequest("Invalid Password");
                }
            }

            return Ok(user);
        }

        public class LoginRequest
        {
            public required string Username { get; set; }
            public required string Password { get; set; }
        }
    }
}
