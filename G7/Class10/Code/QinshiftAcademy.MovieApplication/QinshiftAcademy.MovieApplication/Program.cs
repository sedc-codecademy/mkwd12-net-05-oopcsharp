using QinshiftAcademy.MovieApplication.Domain.Enums;
using QinshiftAcademy.MovieApplication.Domain.Models;

Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
Movie movie3 = new Movie("Saw", Genre.Horror, 4);
Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
Movie movie5 = new Movie("Rambo", Genre.Action, 4);
Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
Movie movie9 = new Movie("Passengers", Genre.Sci_Fi, 4);
Movie movie10 = new Movie("Interstellar", Genre.Sci_Fi, 4);
List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
Movie movie19 = new Movie("Inception", Genre.Sci_Fi, 4);
Movie movie20 = new Movie("Avatar", Genre.Sci_Fi, 4);
List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


Cinema cinema1 = new Cinema("Cineplex");
cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
cinema1.Movies = MovieSet1;
Cinema cinema2 = new Cinema("Milenium");
cinema2.Halls = new List<int>() { 1, 2 };
cinema2.Movies = MovieSet2;

try
{
    int cinemaOption = GetCinemaOption();

    Cinema cinema = null;
    if(cinemaOption == 1)
    {
        cinema = cinema1;
    }
    else
    {
        cinema = cinema2;
    }


    Console.WriteLine("What do you want to search for? 1) All movies 2) Movies by genre");
    string movieInput = Console.ReadLine();

    int movieOption = int.Parse(movieInput);  //potential FormatException  

    if(movieOption == 1)
    {
        //EXTRACTED IN PLAYMOVIE METHOD
        //Console.WriteLine("Enter one of the movies' titles");
        //foreach(Movie movie in cinema.Movies)
        //{
        //    Console.WriteLine(movie.Title);
        //}

        //string movieTitle = Console.ReadLine();

        ////we try to check if he entered a valid movie title
        //Movie cinemaMovie = cinema.Movies.FirstOrDefault(m => m.Title.ToLower() == movieTitle.ToLower());

        //if(cinemaMovie != null)
        //{
        //    cinema.MoviePlaying(cinemaMovie);
        //}
        //else
        //{
        //    throw new Exception("The movie you entered was not valid, was not found");
        //}

        PlayMovie(cinema, cinema.Movies);
    }
    else if(movieOption == 2)
    {
        //1. we need to show all the genres, so user can choose
        Console.WriteLine("Choose a genre:");
        Console.WriteLine("1) Comedy");
        Console.WriteLine("2) Action");
        Console.WriteLine("3) Horror");
        Console.WriteLine("4) Drama");
        Console.WriteLine("5) SciFi");

        string genreInput = Console.ReadLine();
        int genreOption = int.Parse(genreInput);

        if(genreOption < 1 || genreOption > 5)
        {
            throw new Exception("Invalid genre option. Enter a number between 1 and 5");
        }

        //2. we need to filter the movies and show only movies from that genre
        //we can't compare a property that's of type Genre enum with an int value,although each enum member has a numerica value
        //so we must convert one of the values that we are comparing to the opposite type

        //either convert the enum value to the appropriate int value
        List<Movie> filteredMovies = cinema.Movies.Where(m => (int)m.Genre == genreOption).ToList();

        //or convert the int option to the appropriate Genre enum member
        //List<Movie> filteredMovies = cinema.Movies.Where(m => m.Genre == (Genre)genreOption).ToList();

        //3. the user needs to choose a movie but from the filtered ones
        //WE EXTRACTED THIS IN THE PLAYMOVIE METHOD
        //Console.WriteLine("Enter one of the movies' titles");
        //foreach (Movie movie in filteredMovies)
        //{
        //    Console.WriteLine(movie.Title);
        //}

        //string movieTitle = Console.ReadLine();

        ////we try to check if he entered a valid movie title
        //Movie cinemaMovie = filteredMovies.FirstOrDefault(m => m.Title.ToLower() == movieTitle.ToLower());

        //if (cinemaMovie != null)
        //{
        //    cinema.MoviePlaying(cinemaMovie);
        //}
        //else
        //{
        //    throw new Exception("The movie you entered was not valid, was not found");
        //}

        PlayMovie(cinema, filteredMovies);
    }
    else
    {
        throw new Exception("You should enter 1 or 2 as options for action for movies");
    }

}
catch(FormatException e)
{
    Console.WriteLine("Invalid input. You should enter a number");
}
catch(Exception e)
{
    Console.WriteLine("An error occurrred");
    Console.WriteLine(e.Message);
}

int GetCinemaOption()
{
    Console.WriteLine("Please choose a cinema 1) or 2)");
    string cinemaInput = Console.ReadLine();

    int cinemaOption = int.Parse(cinemaInput); //potential FormatException

    if (cinemaOption != 1 && cinemaOption != 2)
    {
        throw new Exception("You must enter option 1 or 2 for the cinema");
    }

    return cinemaOption;
}

void PlayMovie(Cinema cinema, List<Movie> movies)
{
    Console.WriteLine("Enter one of the movies' titles");
    foreach (Movie movie in movies)
    {
        Console.WriteLine(movie.Title);
    }

    string movieTitle = Console.ReadLine();

    //we try to check if he entered a valid movie title
    Movie cinemaMovie = movies.FirstOrDefault(m => m.Title.ToLower() == movieTitle.ToLower());

    if (cinemaMovie != null)
    {
        cinema.MoviePlaying(cinemaMovie);
    }
    else
    {
        throw new Exception("The movie you entered was not valid, was not found");
    }
}
