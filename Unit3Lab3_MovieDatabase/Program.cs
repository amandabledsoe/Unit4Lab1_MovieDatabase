using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4Lab1_MovieDatabase;

List<Movie> movies = new List<Movie>();
movies.Add(new Movie("Encanto", "Animated"));
movies.Add(new Movie("The Aristocats", "Animated"));
movies.Add(new Movie("The Nightmare Before Christmas", "Animated"));
movies.Add(new Movie("House of Gucci", "Drama"));
movies.Add(new Movie("Parasite", "Drama"));
movies.Add(new Movie("Joker", "Drama"));
movies.Add(new Movie("Candyman", "Horror"));
movies.Add(new Movie("The Conjuring", "Horror"));
movies.Add(new Movie("Venom", "Sci-Fi"));
movies.Add(new Movie("The Matrix", "Sci-Fi"));
movies.Add(new Movie("The Meg", "Sci-Fi"));
bool runningProgram = true;

Console.WriteLine("Welcome to the Movie Database Program!");
PauseAndClearScreen();
while (runningProgram)
{
    Console.WriteLine("What category of movie would you like to display?");
    Console.WriteLine("Your options are:");
    Console.WriteLine("\t1. Animated");
    Console.WriteLine("\t2. Drama");
    Console.WriteLine("\t3. Horror");
    Console.WriteLine("\t4. Sci-Fi");
    Console.WriteLine();
    Console.Write("Your Category Choice: ");
    string userChoice = Console.ReadLine().ToLower();
    if (userChoice == "animated")
    {
        Console.WriteLine();
        Console.WriteLine("The Animated movies available are:");
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Category == "Animated")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\t- {movies[i].Title}");
            }
        }
        Console.ResetColor();
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (userChoice == "drama")
    {
        Console.WriteLine();
        Console.WriteLine("The Drama movies available are:");
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Category == "Drama")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\t- {movies[i].Title}");
            }
        }
        Console.ResetColor();
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (userChoice == "horror")
    {
        Console.WriteLine();
        Console.WriteLine("The Horror movies available are:");
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Category == "Horror")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\t- {movies[i].Title}");
            }
        }
        Console.ResetColor();
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (userChoice == "sci-fi")
    {
        Console.WriteLine();
        Console.WriteLine("The Sci-Fi movies available are:");
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Category == "Sci-Fi")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\t- {movies[i].Title}");
            }
        }
        Console.ResetColor();
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
}
Console.WriteLine("Thank you for using the Student Database Program!");
Console.WriteLine("Goodbye...");

static void PauseAndClearScreen()
{
    Console.WriteLine("");
    Console.WriteLine("Press Enter To Continue.");
    Console.ReadLine();
    Console.Clear();
}

static bool WannaRestart()
{
    bool askingThisUser = true;
    while (askingThisUser)
    {
        Console.WriteLine("Would you like to search the database for movies of another category?");
        Console.WriteLine("Enter 'YES' or 'NO'");
        Console.Write("Your Selection: ");
        string userSelection = Console.ReadLine().ToLower();
        if (userSelection == "y" || userSelection == "yes")
        {
            PauseAndClearScreen();
            return true;
        }
        else if (userSelection == "n" || userSelection == "no")
        {
            PauseAndClearScreen();
            return false;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("I'm sorry, I dont understand that response. Please try again.");
            Console.WriteLine();
        }
    }
    return false;
}