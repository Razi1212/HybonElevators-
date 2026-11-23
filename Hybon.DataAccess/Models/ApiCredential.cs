using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybon.DataAccess.Models
{
    public class ApiCredential
    {
        public int Id { get; set; }
        public string ? Username { get; set; }
        public string ? PasswordHash { get; set; }
        public string ? ClientId { get; set; }
        public string ? ClientSecretHash { get; set; }
        public string ?  CompanyCode { get; set; }
        public bool IsActive { get; set; }

    }
}
