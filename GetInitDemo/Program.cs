// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Book book = new Book()
{
    Title = "Paycheck to Paycheck living",
    Author = "Paycheck to Paycheck living",
    Description ="This is a demo of GetInit properties"
};

//Re-nitialization will throw a compile time error as it is not allowed.
//book.Author = "Some person in the world";

Console.WriteLine(book.Author);
Console.WriteLine(book.Description);
Console.WriteLine(book.Title);
Console.ReadLine();

public class Book
{
    public string Title { get; init; } 
    public string Author { get; init; }
    public string Description { get; init; }
}

