using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampC_ {
    internal class Movie {

        public string title;
        public string director;
        private string rating;
        // we changed it to private because, we didn't want anybody outside of Movie class to mess with the rating.

        public Movie(string aTitle, string aDirector, string aRating) {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

        // getters and setters for this rating attribute will allow outside code to access and modify and set the rating.
        // we need a property for this, it looks like plain variable but it contains accessories like get and set.

        public String Rating() {

            get{
                // in the other file, we were not able to get the 'rating'
                return rating;
            }
            set{
                if (value == "G" || value == "PG" || value = "PG-13") {
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
            
        }

    }
}
