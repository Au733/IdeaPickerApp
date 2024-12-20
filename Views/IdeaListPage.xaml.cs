using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerApp.Models;

namespace IdeaPickerApp.Views;

public partial class IdeaListPage : ContentPage
{
    
    public IdeaListPage()
    {
        InitializeComponent();
        Title = "Ideas List";
        
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var ideaTemplate = new DataTemplate(typeof(TextCell)); // creating template to display ListView via TextCells
        ideaTemplate.SetBinding(TextCell.TextProperty, "Suggestion"); // binds TextCell.TextProperty to Title

        listIdeas.ItemTemplate = ideaTemplate; // use the ideaTemplate for showing how each item in ListView will be displayed
        listIdeas.ItemsSource = App.IdeaList.GetIdeas(); // bind ListView to ideas stored in repository and able those store ideas to be displayed
    }

    private void RandomPick_OnClicked(object sender, EventArgs e)
    {
        var random = new Random(); //create new instance of Random used to generate random numbers
        var randomIndex = random.Next(App.IdeaList.GetIdeas().Count);//generate random index used to pick random idea from list in database
        var randomIdea = App.IdeaList.GetIdeas()[randomIndex];//get the random idea from database

        lblRandomIdea.Text = randomIdea.Suggestion;//assigns the idea from database to the label
        
    }
}