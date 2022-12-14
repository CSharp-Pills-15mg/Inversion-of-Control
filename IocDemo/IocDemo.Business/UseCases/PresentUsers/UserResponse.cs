using IocDemo.Ports.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

public class UserResponse
{
    public string? Name { get; set; }

    public string? Country { get; set; }

    public GenderResponse Gender { get; set; }

    public UserResponse(User user)
    {
        Name = user.Name;
        Country = user.Country;
        Gender = user.Gender.ToResponse();
    }
}