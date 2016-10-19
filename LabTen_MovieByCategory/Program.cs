using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen_MovieByCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Movie.Category myAnimated = Movie.Category.HORROR;


            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are " + MovieIO.MovieCatalog.Count + " movies in this list.");

            string movieCategorySelect = "";
            string Cont = "";

            //List<Movie.Category> listOfCategories = new List<Movie.Category>();

            //listOfCategories.AddRange(Enum.GetValues(typeof(Movie.Category)).Cast<Movie.Category>());

            do
            {
                ////foreach (var genRe in listOfCategories)                                                                                                                                                                                                                                                                                                                                            
                //{
                //    Console.WriteLine( (int)genRe+"-"+  genRe.ToString()+" ");
                //}
                Console.WriteLine("What Category are you interested in? 1. drama  2. scifi 3. musical 4. animated 5.comedy");
                movieCategorySelect = Console.ReadLine();

                int countMovieMatch = 0;

                foreach (Movie l1 in MovieIO.MovieCatalog.OrderBy(m => m.title))
                {

                    if (movieCategorySelect == l1.category)
                    {
                        Console.WriteLine("Title: " + l1.title);
                        countMovieMatch++;

                    }
                    if (countMovieMatch == 10)
                        break;
                }
                Console.WriteLine("Do you want to continue? Type yes or no");
                Cont = Console.ReadLine().ToLower().Trim();
            } while (Cont == "yes"); Console.WriteLine("Thank you for your inquiry");
        }
            
    }
}

