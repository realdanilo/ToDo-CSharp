using System;
using System.Collections.Generic;
using System.Text;

namespace HellloWorld
{
    class Book
    {
        private string author;
        private string title;
        private int pages;
        private DateTime date;
        
        public Book(string _author, string _title, int _pages)
        {
            author = _author;
            title = _title;
            pages = _pages;
            date = DateTime.Now;

        }
        public void printInfo()
        {
            Console.Write($"\t{this.title} \n\t{this.author} \n\t{this.pages}");

        }
        public bool isInsane()
        {
            
            return this.pages > 100;
        }
        public int Pages
        {
            get { return this.pages; }
            set
            {
                if(value > 10) { this.pages = value; }
                else
                {
                    Console.WriteLine("cannot update value");
                }
            }
               
            
        }
        public DateTime GetTime
        {
            get { return this.date; }
            
        }

    }
}
