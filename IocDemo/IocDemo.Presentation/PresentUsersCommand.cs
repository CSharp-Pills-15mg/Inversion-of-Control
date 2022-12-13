using IocDemo.Business.UseCases.PresentUsers;

namespace IocDemo.Presentation;

public class PresentUsersCommand
{
    private readonly PresentUsersUseCase presentUsersUseCase;
    private readonly UsersView usersView;

    public PresentUsersCommand(PresentUsersUseCase presentUsersUseCase, UsersView usersView)
    {
        this.presentUsersUseCase = presentUsersUseCase ?? throw new ArgumentNullException(nameof(presentUsersUseCase));
        this.usersView = usersView ?? throw new ArgumentNullException(nameof(usersView));
    }

    public void Execute()
    {
        PresentUsersRequest request = new()
        {
            Name = "ar"
        };

        PresentUsersResponse response = presentUsersUseCase.Execute(request);

        usersView.ViewModel = new UsersViewModel
        {
            Users = response.Users
        };

        usersView.Display();
    }
}