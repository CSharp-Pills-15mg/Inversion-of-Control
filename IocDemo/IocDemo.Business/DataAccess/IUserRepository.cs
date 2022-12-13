namespace IocDemo.DataAccess;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
}