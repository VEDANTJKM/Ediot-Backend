using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Dashboard.Models;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Claims;


namespace Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly string _connectionString;

        public LoginController(IConfiguration configration, IteindiaContext dbContext)
        {
            _config = configration;
            _connectionString = _config.GetConnectionString("cs");
        }

        private async Task<Login> Authenticate(Login user)
        {
            Login authenticatedUser = null;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(
                    "SELECT LOGIN_ID, PASSWORD_CHNG, EmployeePosition,personID FROM USER_MST WHERE LOGIN_ID = @email AND PASSWORD_CHNG = @Password  ",
                    sqlConnection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@Password", user.Password); // Hash passwords in real applications
                    // Hash passwords in real applications

                    await sqlConnection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            authenticatedUser = new Login

                            {
                                UserId = (int)reader["personID"],
                                Username = reader["LOGIN_ID"].ToString(),
                                email = reader["LOGIN_ID"].ToString(),
                                Password = reader["PASSWORD_CHNG"].ToString(), // Do not return raw passwords
                                Position = reader["EmployeePosition"].ToString() // Store position
                            };
                        }
                    }
                }
            }
            return authenticatedUser;
        }


        private string GenerateToken(Login user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.email),
        new Claim("Position", user.Position), // Add EmployeePosition as a claim
        new Claim("UserId", user.UserId.ToString()), // Add EmployeePosition as a claim
         
    };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(3), // Token expires in 30 minutes
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Login user)
        {
            IActionResult response = Unauthorized();

            // Authenticate user and fetch position
            var authenticatedUser = await Authenticate(user);

            if (authenticatedUser != null)
            {
                var token = GenerateToken(authenticatedUser);
                response = Ok(new
                {
                    status = "success",
                    token = token,
                    data = new
                    {
                        authenticatedUser.Username,
                        authenticatedUser.UserId,
                        authenticatedUser.Position // Include Position in the response
                    }
                });
            }

            return response;
        }


    }
}
