using Hybon.Business.Interfaces;
using Hybon.Model.Models;

namespace Hybon.Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordService _passwordService;

        public AuthService(IAuthRepository authRepository,IPasswordService passwordService)
        {
            _authRepository = authRepository;
            _passwordService = passwordService;

        }

        public async Task<LoginResponse ?> LoginAsync(LoginRequest request)
        {
            var credential = await _authRepository.GetByClientIdAsync(request.ClientId);

            if (credential == null)
            {
                throw new UnauthorizedAccessException("Invalid client credentials");
            }

            if (!credential.IsActive)
            {
                throw new UnauthorizedAccessException("Account is inactive");
            }

            if (!_passwordService.VerifyPassword(credential.PasswordHash,request.Password))
            {
                throw new UnauthorizedAccessException("Invalid username or password");
            }

            throw new NotImplementedException();

        }
    }
}
