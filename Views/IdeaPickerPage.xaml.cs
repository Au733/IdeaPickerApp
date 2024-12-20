using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerApp.Models;

namespace IdeaPickerApp.Views;

public partial class IdeaPickerPage : ContentPage
{
    public IdeaPickerPage()
    {
        InitializeComponent();
        Title = "Idea Picker Page";
    }


    private void AddIdea_OnClicked(object sender, EventArgs e)
    {
        var newIdea = new Idea(); // creating new instance of Idea class
        newIdea.Suggestion = txtIdea.Text;
        
        App.IdeaList.SaveIdea(newIdea); // adding new idea data to repository

        txtIdea.Text = string.Empty; 
        
    }
    
    
    
}