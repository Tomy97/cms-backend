using gestor_backend.Data.Entities;

namespace gestor_backend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
    }
}
