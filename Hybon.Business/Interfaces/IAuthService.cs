using Hybon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybon.Business.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponse?> LoginAsync(LoginRequest request);
    }
}
