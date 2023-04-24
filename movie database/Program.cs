namespace movie_database
{
    using System;
    using System.Collections.Generic;

    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }
        public int YearReleased { get; set; }

        public Movie(string title, string category, int runtime, int yearReleased)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            YearReleased = yearReleased;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Lion King", "animated", 88, 1994));
            movies.Add(new Movie("Forrest Gump", "drama", 142, 1994));
            movies.Add(new Movie("The Shining", "horror", 144, 1980));
            movies.Add(new Movie("Blade Runner", "scifi", 117, 1982));
            movies.Add(new Movie("Toy Story", "animated", 81, 1995));
            movies.Add(new Movie("A Beautiful Mind", "drama", 135, 2001));
            movies.Add(new Movie("The Exorcist", "horror", 122, 1973));
            movies.Add(new Movie("Interstellar", "scifi", 169, 2014));
            movies.Add(new Movie("Coco", "animated", 105, 2017));
            movies.Add(new Movie("The Godfather", "drama", 175, 1972));

            while (true)
            {
                Console.WriteLine("Enter a movie category (animated, drama, horror, scifi) to display movies: ");
                string input = Console.ReadLine().ToLower();

                bool foundMatch = false;
                List<Movie> matches = new List<Movie>();
                foreach (Movie movie in movies)
                {
                    if (movie.Category.ToLower() == input)
                    {
                        matches.Add(movie);
                        foundMatch = true;
                    }
                }

                if (!foundMatch)
                {
                    Console.WriteLine("No movies in that category were found.");
                }
                else
                {
                    matches.Sort((x, y) => x.Title.CompareTo(y.Title));
                    Console.WriteLine($"{"Title",-25}{"Category",-15}{"Runtime (min)",-15}{"Year Released"}");
                    foreach (Movie match in matches)
                    {
                        Console.WriteLine($"{match.Title,-25}{match.Category,-15}{match.Runtime,-15}{match.YearReleased}");
                    }
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "n" || choice == "no")
                {
                    break;
                }
            }
        }
    }

}

