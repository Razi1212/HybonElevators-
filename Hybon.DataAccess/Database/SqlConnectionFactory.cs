using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Hybon.DataAccess.Database
{
    public class SqlConnectionFactory
    {
        private readonly string _connectionstring;

        public SqlConnectionFactory(string connectionstring)
        {
            if (string.IsNullOrWhiteSpace(connectionstring)) throw new ArgumentException("connection string is missing");

            _connectionstring = connectionstring;

        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionstring);
        }
    }
}
