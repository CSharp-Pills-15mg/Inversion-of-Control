namespace IocDemo.Ports.DataAccess;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
}