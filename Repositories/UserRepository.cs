using gestor_backend.Data;
using gestor_backend.Data.Entities;
using gestor_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gestor_backend.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Email == email);
        }
    }
}
