using System;
using Dapper;
using Hybon.DataAccess.Database;
using Hybon.DataAccess.Interfaces;
using Hybon.DataAccess.Models;



namespace Hybon.DataAccess.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SqlConnectionFactory _connectionFactory;

        public AuthRepository(SqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }


        public async Task<ApiCredential?> GetByClientIdAsync(string clientId)
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"SELECT
            Id,
            Username,
            PasswordHash,
            ClientId,
            ClientSecretHash,
            CompanyCode,
            IsActive
        FROM dbo.ApiCredentials
        WHERE ClientId = @ClientId";

            return await connection.QuerySingleOrDefaultAsync<ApiCredential>(
                sql,
                new { ClientId = clientId }
            );
        }

    }
}
