using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    // Create a new class. (Lesson: Objects & Classes)
    public class PersonalDigitalLibrary
    {
        // Create a nested class within the current class and make it a list.
        public List<Book> Books { get; set; }

        public PersonalDigitalLibrary()
        {
            Books = new List<Book>();
        }

        // Create a method on your class to accept new books. (Lesson: Methods)
        public void AddBook(Book book)
        {
            // Make sure to use defensive programming to keep out nulls
            if (book is null)
            {
                throw new ArgumentNullException();
            }

            Books.Add(book);
        }
    }
}