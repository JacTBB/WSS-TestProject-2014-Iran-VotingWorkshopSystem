using Microsoft.AspNetCore.Mvc;
using System.Numerics;
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
            User? user = dbContxext.Users.FirstOrDefault(u => u.Username == loginRequest.Username && u.Password == loginRequest.Password);

            if (user == null)
            {
                return NotFound();
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
