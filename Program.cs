using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myAuthor.ToString());
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.GetAuthor().ToString());
            Book yourBook = new Book("4321", "The Phanton Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
