using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}