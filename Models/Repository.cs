using SQLite;

namespace IdeaPickerApp.Models;

public class Repository
{
    private readonly SQLiteConnection _database; //internal private database variable
    
    public Repository () 
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ideas.db"); //creating path to folder where data files are stored / database path

        _database = new SQLiteConnection(dbPath); //create connection to database
        _database.CreateTable<Idea>(); //create table
    }

    public List<Idea> GetIdeas() //method to get idea list
    {
        return _database.Table<Idea>().ToList();
        //return _database.Query<Idea>("Select * from Idea where ID > 2"); //Querying database for specific data
    }

    public void SaveIdea(Idea idea) //method to insert idea into database table
    {
        _database.Insert(idea);
    }
}