using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using ConsoleApp1;
using Coding.Exercise;
namespace Prog
{
    public class Program

    {
       
        public static void Main(string[] args)
        {
            /*  //**** Downloading Google main page 
              using (WebClient client = new WebClient())
              {
                  string googleMainPage = client.DownloadString("https://www.google.com/");
                  Console.WriteLine(googleMainPage);
              }*/
            
           Inheritance x = new Inheritance();
            x.Firstname = "Mayank"; //derived class object accesing the base class properties
            x.Lastname = "Bisht";
         
            Console.WriteLine(x.Firstname);
            Console.WriteLine(x.Lastname);
            x.employ("mayank", 1, 1_00_000);
            x.display();
            // Create an instance of PersonalDigitalLibrary
            PersonalDigitalLibrary myLibrary = new PersonalDigitalLibrary();

            // Create some book instances
            Book book1 = new Book("The boy who loved", "Durjoy datta ", "4456543");
            Book book2 = new Book("Perfect us", "Durjoy datta","4657680");
            Book book3 = new Book("Wings of fire", "APJ","4457672");

            // Add the books to the library
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);

            // Display the books in the library
            Console.WriteLine("Books in the library:");
            foreach (Book book in myLibrary.Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }


        }
    }
}
