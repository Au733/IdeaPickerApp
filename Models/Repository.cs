using SQLite;

namespace IdeaPickerApp.Models;

public class Repository
{
    private readonly SQLiteConnection _database; //internal private database variable
    
    public Repository () 
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ideas.db"); //creating database path to where data files are stored

        _database = new SQLiteConnection(dbPath); //create connection to database
        _database.CreateTable<Idea>(); //create table
    }

    public List<Idea> GetIdeas() //method to get idea list
    {
        return _database.Table<Idea>().ToList();
        
    }

    public void SaveIdea(Idea idea) //method to insert idea into database table
    {
        _database.Insert(idea);
    }
}