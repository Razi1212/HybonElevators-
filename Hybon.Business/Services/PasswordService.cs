using Hybon.Business.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Hybon.Business.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly PasswordHasher<string> _passwordHasher;

        public PasswordService()
        {
            _passwordHasher = new PasswordHasher<string>();
        }

        public string HashPassword(string password)
        {
            return _passwordHasher.HashPassword("Hybon", password);
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(
                "Hybon",
                hashedPassword,
                providedPassword
            );

            return result != PasswordVerificationResult.Failed;
        }
    }
}
