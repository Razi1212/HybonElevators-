using Hybon.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybon.DataAccess.Interfaces
{
    public interface IAuthRepository
    {
        Task<ApiCredential?> GetByClientIdAsync(string clientId);

    }
}
