using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybon.Business.Interfaces
{
    public interface IPasswordService
    {

       string HashPassword(string password);

        bool VerifyPassword(string hashedPassword, string providedPassword);

    }

}
