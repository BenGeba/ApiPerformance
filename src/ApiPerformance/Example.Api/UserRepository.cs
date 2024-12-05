using System.Data;
using Dapper;
using MySqlConnector;

namespace Example.Api;

public class UserRepository : IUserRepository
{
    private readonly IDbConnection _connection;

    public UserRepository(string connectionString)
    {
        _connection = new MySqlConnection(connectionString);
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _connection.QueryAsync<User>("SELECT * FROM sample_data");
    }
}