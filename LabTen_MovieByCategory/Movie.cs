using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen_MovieByCategory
{
    public class Movie
    {
        public string title = "";
        //public Category category;
        public string category = "";
        public Movie(string Title, string movieCategory)
        {
            this.title = Title;
            this.category = movieCategory;
            //this.category = movieCategoryConverter(movieCategory);


        }
        public enum Category { ANIMATED=4 ,DRAMA=3, HORROR=18, SCIFI, COMEDY, UNCATEGORIZED};

        
        private Category movieCategoryConverter(string category)
        {
           

            if (category == "animated" )
            {
                return Category.ANIMATED;

            }
            else if (category == "drama")
            {
                return Category.DRAMA;
            }
            else if (category == "horror")
            {
                return Category.HORROR;
            }
            else if (category == "scifi")
            {
                return Category.SCIFI;
            }
            else if (category == "comedy") 
            {
                return Category.COMEDY;
            }
            else
            {
                return Category.UNCATEGORIZED;
                
            }
            
        }
    }
}
    
