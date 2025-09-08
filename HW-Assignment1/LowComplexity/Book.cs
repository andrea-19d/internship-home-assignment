using System;

namespace internship_home_assignment.HW_Assignment2.LowComplexity;

public class Book
{
    string Title { get; set; }
    string Author { get; set; }
    private int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public static Book CreateBook()
    {
        Console.Write($"Enter the book title: ");
        string title = Console.ReadLine();
        Console.Write($"Enter the book author: ");
        string author = Console.ReadLine();
        Console.Write($"Enter the book pages: ");
        int pages = int.Parse(Console.ReadLine());
        
        Book book = new Book(title, author, pages);
        return book;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title},  Author: {Author}, Pages: {Pages}");
    }
}