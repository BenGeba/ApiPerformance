namespace Example.Api;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}