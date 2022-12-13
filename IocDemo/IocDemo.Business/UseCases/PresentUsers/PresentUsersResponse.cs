using IocDemo.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

public class PresentUsersResponse
{
    public List<User> Users { get; set; }
}