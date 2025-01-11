using StoreAdministration.Data;
using StoreAdministration.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAdministration.Controllers
{
    public class UserController
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.Run(() =>
            {
                return _context.Users.ToList();
            });
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            await Task.Run(() =>
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            });
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.Run(() =>
            {
                var existingUser = _context.Users.Find(user.Id);
                if (existingUser != null)
                {
                    _context.Entry(existingUser).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
            });
        }

        public async Task DeleteUserAsync(int id)
        {
            await Task.Run(() =>
            {
                var user = _context.Users.Find(id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            });
        }
    }
}
