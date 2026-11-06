using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class _18 {

        static void Main(string[]args) {

            /*
             * 
             * 
             * NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES NOTES
             * 
             * 
             * Lot of times simple data types like just string or int is not enough to represent everything.
             * Many things in the real world are not representable with a string..you need to break it down to
             * many things.
             * 
             * 
             * Classes and Objects just allow you to create your own custom data type.
             * it has a book class and some attributes, we can now create an Object..which is an instance of a class.
             * 
             * 
             * Constructor is a special method that we can put inside of a C# class, which is going to get called
             * whenever we create an object of that class. So, anytime you create an object of a specific class..
             * the constructor method will get called.
             * 
             * Constructor method's name is the same as the class
             * 
             * Object Methods
             * 
             * Object method is just a method that we can define inside our class that the object can use to use either
             * find our info or modify info about themselves.
             * 
             */


            // refer to Book.cs
            // book1 is an isntance of the Book class
            
            //Book book1 = new Book("Mike");
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;
            

        //  class objname = new_keyword call_class
            Book book2 = new Book("Lord of the Rings","Tolkein",800);

            Console.WriteLine(book2.pages);
            Console.WriteLine(book2.PageLengthReq());

            Console.ReadLine();

        }
    }
}
