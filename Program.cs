//namespace begin

//Create a BookCollection Class
//Make use a Generic Collection (List<string>) to hold book titles
//Add an indexer to access the book list (have some validation)
//AddBook Method: Add a book title to the Book Collection
//Count property to retrive the total count of book titles

//Main 
//Create an instance of the BookCollection class
//Add at least 3 books to the collection
//Access the books using the indexer
//Display the book titles
//Change 1 of the book titles via the indexer
//Display the change book title
//Display all books in collection

namespace LU1_Indexes_Demo
{
    //namespace begin
    internal class Program
    {
        //program class begin
        static void Main(string[] args)
        {
            //Main begin
            //Create an instance of the BookCollection class
            BookCollection myBooks = new BookCollection();

            //Add at least 3 books to the collection
            myBooks.AddBook("The Great Gatsby");
            myBooks.AddBook("1984");
            myBooks.AddBook("To Kill a Mockingbird");

            //Access the books using the indexer
            Console.WriteLine("Book at index 0: " + myBooks[0]);
            Console.WriteLine("Book at index 1: " + myBooks[1]);
            Console.WriteLine("Book at index 2: " + myBooks[2]);

            //Change 1 of the book titles via the indexer
            myBooks[1] = "Brave New World";

            //Display the changed book title
            Console.WriteLine("Changed book at index 1: " + myBooks[1]);

            //Display all books in the collection
            Console.WriteLine("All books in the collection:");
            for (int i = 0; i < myBooks.Count; i++)
            {
                Console.WriteLine(myBooks[i]);
            }
            //Main end
        }

        public class BookCollection
        {
            //Example class begin
            //Generic Collection to hold book titles
            private List<string> books = new List<string>();

            //AddBook Method: Add a book title to the Book Collection
            public void AddBook(string title)
            {
                if (!string.IsNullOrEmpty(title))
                {
                    books.Add(title);
                }
            }

            //Count property to retrieve the total count of book titles
            public int Count
            {
                get { return books.Count; }
            }

            //Indexer to access the book list (with some validation)
            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < books.Count)
                    {
                        return books[index];
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index out of range");
                    }
                }
                set
                {
                    if (index >= 0 && index < books.Count)
                    {
                        if (!string.IsNullOrEmpty(value))
                        {
                            books[index] = value;
                        }
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index out of range");
                    }
                }
            }
            //Example class end
        }
        //program class end
    }
    //namespace end
}
/*
 * 
 * BookCollection Class:
List<string> books: A private list to hold the book titles.
AddBook Method: Adds a book to the list if the title is not null or empty.
Count Property: Returns the total number of books in the collection.
Indexer: Allows accessing and modifying book titles using an index with range validation.
Main Method:
Creates an instance of BookCollection.
Adds three book titles.
Demonstrates accessing and modifying book titles using the indexer.
Prints all book titles in the collection.
 */ 