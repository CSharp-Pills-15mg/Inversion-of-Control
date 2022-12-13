using DustInTheWind.ConsoleTools.Controls.Tables;

namespace IocDemo.Presentation;

public class UsersView
{
    public UsersViewModel? ViewModel { get; set; }

    public void Display()
    {
        if (ViewModel?.Users == null || ViewModel.Users.Count == 0)
        {
            Console.WriteLine("There are no users.");
        }
        else
        {
            DataGrid dataGrid = DataGrid.BuildFrom(ViewModel.Users);
            dataGrid.Border.Template = BorderTemplate.SingleLineBorderTemplate;
            dataGrid.TitleRow.IsVisible = false;
            dataGrid.Display();
        }
    }
}