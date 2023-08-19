using JWTAuth.Models;
using JWTAuth.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Global_Exception;

namespace JWTAuth.Services
{
    public class UserService : IUser
    {
        public PayodaStudentMgmtContext _context;

        public UserService(PayodaStudentMgmtContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users =await _context.Users.ToListAsync();
            return users;

        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var rusers = await _context.Users.FindAsync(username);
            if (rusers != null)
            {
                _context.Users.Remove(rusers);
                await _context.SaveChangesAsync();
               var  ruser = await _context.Users.ToListAsync();
                return ruser;
            }
            else
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[1]);
            }
            
        }

        public async Task<User> GetUserByUsername(string username)
        {
            var users = await _context.Users.FirstOrDefaultAsync(p => p.Username == username); ;
            
            if (users != null)
            {
                return users;
            }
           else
            {
                    throw new Exception(StudentDetailsExceptions.ExceptionMessages[1]);
           }
    
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var rusers = await _context.Users.FindAsync(username);
            if(rusers!=null)
            {
                rusers.Password=user.Password;
                rusers.Role=user.Role;
                await _context.SaveChangesAsync();
                rusers = await _context.Users.FindAsync(username);
                return rusers;
            }
            else
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[1]);
            }
        }
    }
}
