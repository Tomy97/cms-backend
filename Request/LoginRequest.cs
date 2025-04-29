namespace gestor_backend.Request
{
    public class LoginRequest
    {
        public required string email { get; set; }
        public required string password { get; set; }
    }
}
