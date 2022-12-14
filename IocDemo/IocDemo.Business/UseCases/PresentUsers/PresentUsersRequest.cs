using IocDemo.Ports.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

public class PresentUsersRequest
{
    public string? Name { get; set; }

    public string? Country { get; set; }

    public Gender? Gender { get; set; }
}