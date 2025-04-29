using gestor_backend.Data;
using gestor_backend.Repositories.Interfaces;
using gestor_backend.Services.Interfaces;

namespace gestor_backend.Services
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> ValidateCredentials(string email , string password)
        {
            var userExist = await _userRepository.GetUserByEmailAsync(email);

            if (userExist == null)
            {
                return false;
            }

            if (userExist.Password != password)
            {
                return false;
            }
            return true;
        }

        public async Task<string> GenerateTokenAsync(string email)
        {
            
            return "string";
        }
    }
}
