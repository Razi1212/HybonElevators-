using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybon.Model.Models
{
    public class LoginRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password  { get; set; }
    }
}
