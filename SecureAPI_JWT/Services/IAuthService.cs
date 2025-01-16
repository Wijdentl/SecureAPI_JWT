using SecureAPI_JWT.Models;

namespace SecureAPI_JWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
