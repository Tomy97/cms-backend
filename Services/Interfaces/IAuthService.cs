namespace gestor_backend.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> ValidateCredentials(string email, string password);
        Task<string> GenerateTokenAsync(string email);
    }
}
