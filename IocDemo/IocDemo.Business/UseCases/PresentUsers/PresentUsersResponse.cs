using IocDemo.Ports.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

public class PresentUsersResponse
{
    public List<UserResponse> Users { get; set; }
}