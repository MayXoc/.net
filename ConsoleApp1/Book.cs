using System;

namespace Coding.Exercise
{
    // Create a new class. (Lesson: Objects & Classes)
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }

        // Create a constructor and use defensive programming to check all values. (Lesson: Constructors)
        public Book(string title, string author, string isbn)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title is required.");
            }

            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentException("Author is required.");
            }

            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentException("ISBN is required.");
            }

            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
}