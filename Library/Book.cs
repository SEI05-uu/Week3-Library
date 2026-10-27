namespace Library;

public class Book
{
    private string title;
    private string author;
    private string isbn;

    public string Title
        {
            get { return title; }  
            set { title = value; } 
    }
    
    public string Author
    {
        get {return author;}
        set
        {
            if (!value.Any(char.IsDigit))
            {
                author = value;
            }
            else
            {
                Console.WriteLine("Error: Author name cannot contain numbers.");
            }
        }
    }

    public string ISBN
    {
        get {return isbn;}
        set
        {
            if (value != "") 
            {
                isbn = value; 
            }
            else
            {
                Console.WriteLine("Error: ISBN cannot be blank.");
            }
        }
    }

 
    public Book(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }
 
    public void DisplayInfo()
    {
        Console.WriteLine($"Book title: {title}");
        Console.WriteLine($"Book Author: {author}");
        Console.WriteLine($"Book ISBN: {isbn}");
        Console.WriteLine();
    }
}