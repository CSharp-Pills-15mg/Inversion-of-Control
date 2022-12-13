using IocDemo.Business.UseCases.PresentUsers;
using IocDemo.DataAccess;
using IocDemo.Presentation;

namespace IocDemo.Bootstrapper;

internal static class Program
{
    private static void Main()
    {
        UserRepository userRepository = new();
        PresentUsersUseCase presentUsersUseCase = new(userRepository);
        UsersView usersView = new();
        PresentUsersCommand command = new(presentUsersUseCase, usersView);

        command.Execute();
    }
}