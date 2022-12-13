using IocDemo.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

public class PresentUsersUseCase
{
    private readonly UserRepository userRepository;

    public PresentUsersUseCase(UserRepository userRepository)
    {
        this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public PresentUsersResponse Execute(PresentUsersRequest request)
    {
        IEnumerable<User> users = userRepository.GetAll();

        if (!string.IsNullOrEmpty(request.Name))
            users = users.Where(x => x.Name.Contains(request.Name, StringComparison.InvariantCultureIgnoreCase));

        if (!string.IsNullOrEmpty(request.Country))
            users = users.Where(x => x.Country.Contains(request.Country, StringComparison.CurrentCultureIgnoreCase));

        if (request.Gender != null)
            users = users.Where(x => x.Gender == request.Gender);

        return new PresentUsersResponse
        {
            Users = users.ToList()
        };
    }
}