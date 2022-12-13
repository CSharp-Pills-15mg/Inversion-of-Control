using IocDemo.Business.DataAccess;
using IocDemo.Business.UseCases.PresentUsers;
using IocDemo.Presentation;

namespace IocDemo;

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