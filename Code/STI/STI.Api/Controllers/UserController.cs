using STI.Api.Stubs;
using STI.BAL.Models.DTOs;
using STI.BAL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace STI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public IActionResult LoginAsync(UserLoginRequest request)
        {
            var user = AuthenticateUserLogin(request);

            if (user != null)
                return Ok(CreateUserAccesToken(user));

            return NotFound("User not found");
        }

        private UserDTO AuthenticateUserLogin(UserLoginRequest request)
        {
            var currentUser = Stub.Users.FirstOrDefault(data => data.Username.ToLower() == request.Username.ToLower() &&
                                                                data.Password.ToLower() == request.Password.ToLower());

            if (currentUser != null)
                return currentUser;

            return null;
        }
        private string CreateUserAccesToken(UserDTO user)
        {
            //Get JWT Security Key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            //Get Credentials using JWT Security Key
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Create Identity Claims such as Actor, Name, Role and etc.
            var claims = new []
            {
                new Claim(ClaimTypes.Actor, user.InternalID.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                //new Claim(ClaimTypes.Email, user.Email),
                //new Claim(ClaimTypes.GivenName, user.FirstName),
                //new Claim(ClaimTypes.Surname, user.LastName),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };

            //Create Security Token based on the JWT Issuer, JWT Audience, Claims, Expirations and Credentials
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims, 
                                             expires: DateTime.Now.AddMinutes(10), signingCredentials: credentials);

            //Create User Access Token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
