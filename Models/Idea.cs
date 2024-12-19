using SQLite;

namespace IdeaPickerApp.Models;

public class Idea
{
    [PrimaryKey, AutoIncrement]
    
    public int Id { get; set; }

    public string Suggestion { get; set; }
}