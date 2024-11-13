// See https://aka.ms/new-console-template for more information
using Movie_Database_Lab;

Console.WriteLine("Welcome to Syeda's movie list application!");

// Task: List movies by category 
/* What will the application do? 
 * The app stores a list of 10 movies and displays them by category
 * the user can enter any of the following categories to display the film: animated/drama/horror/scifi
 * After the list is displayed, the user is asked if he or she wants to continue. if no, the program ends.\*
 */

//2.  Create List<Movies> and store 10 movies.

List<Movies> movies = new List<Movies>()
{
    new Movies("Interstellar","scifi") ,
    new Movies("Emma","drama"),
    new Movies("The Martian","scifi"),
    new Movies("Inception","scifi"),
    new Movies("Into the tall grass","horror"),
    new Movies("Persuasion","drama"),
    new Movies("Us","horror"),
    new Movies("Coco","animated"), 
    new Movies("Coraline","animated"),
    new Movies("Shrek","animated"),

};

//3. When the user enters a category, the program should display a line
//for any movie whose category matches. 
// if there is a invalid category make sure theres feedback 
// program only outputs movies that match its category. 


//Console.WriteLine($"There are {movies.Count} movies in this list ");
//Console.WriteLine("What category are you interested in? Pick from animated, drama, horror, or scifi");
//string selectedCategory = Console.ReadLine();

//List<Movies> categoryPicked = movies.Where(x => x.movieCategory.ToLower().Contains(selectedCategory)).ToList();

// Basically I wanna say if the user entered a valid input, show list of movies. But if they didn't, tell them
//they chose something invalid and exit out of the loop 
// and on the outside I want a do while loop that lets the user ask for more movies. 

bool playAgain = true;
do
{
    Console.WriteLine($"There are {movies.Count} movies in this list ");
    Console.WriteLine("What category are you interested in? Pick from animated, drama, horror, or scifi");
    string selectedCategory = Console.ReadLine();

    List<Movies> categoryPicked = movies.Where(x => x.movieCategory.ToLower().Contains(selectedCategory)).ToList();

    if (categoryPicked.Count > 0)
    {
        foreach (var movie in categoryPicked)
        {
            Console.WriteLine(movie.movieTitle);
           
        }
    }
    else
    {
        Console.WriteLine("That was an invalid input!");
     
    }

    Console.WriteLine("Would you like to go again (Y/N)?");
   string goAgain = Console.ReadLine();
    if (goAgain.ToLower() == "n")
    {
        playAgain = false;
        break;
    }
}
while (playAgain == true);

//3. When the user enters a category, the program should display a line
//for any movie whose category matches. 
// if there is a invalid category make sure theres feedback 
// program only outputs movies that match its category. 
