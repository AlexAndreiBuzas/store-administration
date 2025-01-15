using StoreAdministration.Data;
using StoreAdministration.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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
            Trace.WriteLine("Getting all users");

            return await Task.Run(() =>
            {
                return _context.Users.ToList();
            });
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            Trace.WriteLine($"Getting user by username: {username}");

            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            Trace.WriteLine($"Adding user: {user.Username}");

            await Task.Run(() =>
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            });
        }

        public async Task UpdateUserAsync(User user)
        {
            Trace.WriteLine($"Updating user: {user.Username}");

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
            Trace.WriteLine($"Deleting user with id: {id}");

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
