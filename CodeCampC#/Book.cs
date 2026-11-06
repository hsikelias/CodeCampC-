using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    class Book {
        // think about what the different attributes that can represent a book
        // class attributes: Information that describe the class


        // ATTRIBUTES
        public string title;
        public string author;
        public int pages;


        // CONSTRUCTOR
        public Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPage;
        }

        
        // OBJECT METHODS
        public bool PageLengthReq() {
            
            if (pages >= 500) {
                return true;
            }
            return false;
        }
    }
}
