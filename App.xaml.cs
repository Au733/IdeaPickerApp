using IdeaPickerApp.Models;

namespace IdeaPickerApp;

public partial class App : Application
{
    public static Repository IdeaList; //IdeaList variable which provides access and enables management of database
    
    public App()
    {
        InitializeComponent();
        IdeaList = new Repository();
        MainPage = new AppShell();
    }
}