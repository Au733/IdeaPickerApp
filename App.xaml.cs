using IdeaPickerApp.Models;

namespace IdeaPickerApp;

public partial class App : Application
{
    public static Repository IdeaList;
    
    public App()
    {
        InitializeComponent();
        IdeaList = new Repository();
        MainPage = new AppShell();
    }
}