using System;
using System.Collections.Generic;
using System.Text;

namespace HellloWorld
{
    class EntryPoint
    {
        static void Main()
        {
            bool runningApp = true;
            List<Book> bookList = new List<Book>();
            Console.WriteLine("Hello to OOP App");
            while (runningApp)
            {
                Console.WriteLine("Enter Book Name");
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter book author");
                string bookAuthor = Console.ReadLine();
                Console.WriteLine("Enter number of pages in book");
                int bookPages = int.Parse(Console.ReadLine());
                Book myBook = new Book(bookName, bookAuthor, bookPages);

                //add book to list
                bookList.Add(myBook);
                // ask if user wants to add more books
                Console.WriteLine("Would you like to add more books?   \n\tEnter: Y/N");
                runningApp = Console.ReadLine().ToLower().Contains("y") ;

            }
            //for each book, print information
            Console.WriteLine("Printing books");
            foreach(Book book in bookList)
            {
                book.printInfo();
                Console.WriteLine($"Created: {book.GetTime} \n\t***** ");
                
            }


        }
    }
}





