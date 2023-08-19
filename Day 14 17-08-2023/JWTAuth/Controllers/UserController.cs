using JWTAuth.Models;
using JWTAuth.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {
        private IUser _user;
        private IToken _tokenGenerator;

        public UserController(IUser user, IToken tokenGenerator)
        {
            _user = user;
            _tokenGenerator = tokenGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserByUsername(string username)
        {
            try
            {
                var user = await _user.GetUserByUsername(username); 
                var token=_tokenGenerator.GenerateToken(user.Username,user.Role);
                Console.WriteLine(token);
                return Ok(token);    
            }
            catch (Exception ex) 
            { 
                return NotFound(ex.Message);    
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            var packages = await _user.AddUser(user);
            return Ok(packages);
        }

    }
}
