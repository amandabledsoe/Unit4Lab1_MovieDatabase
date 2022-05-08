using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unit4Lab1_MovieDatabase;

List<Movie> movies = new List<Movie>();
movies.Add(new Movie("Encanto", "Animated", 109, new DateTime(2021, 11, 24)));
movies.Add(new Movie("The Aristocats", "Animated", 78, new DateTime(1970, 12, 24)));
movies.Add(new Movie("The Nightmare Before Christmas", "Animated", 76, new DateTime(1993, 10, 13)));
movies.Add(new Movie("House of Gucci", "Drama", 158, new DateTime(2021, 11, 24)));
movies.Add(new Movie("Parasite", "Drama", 132, new DateTime(2019, 05, 30)));
movies.Add(new Movie("Joker", "Drama", 122, new DateTime(2019, 10, 04)));
movies.Add(new Movie("Candyman", "Horror", 91, new DateTime(2021, 08, 27)));
movies.Add(new Movie("The Conjuring", "Horror", 112, new DateTime(2021, 06, 04)));
movies.Add(new Movie("Venom", "Sci-Fi", 140, new DateTime(2021, 10, 01)));
movies.Add(new Movie("The Matrix", "Sci-Fi", 136, new DateTime(1999, 03, 31)));
movies.Add(new Movie("The Meg", "Sci-Fi", 113, new DateTime(2018, 08, 10)));

movies.Sort(delegate (Movie x, Movie y) 
{
    return x.Title.CompareTo(y.Title);
});

bool runningProgram = true;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Welcome to the Movie Database Program!");
Console.ResetColor();
PauseAndClearScreen();
while (runningProgram)
{
    Console.WriteLine("What category of movie would you like to display?");
    Console.WriteLine("Your options are:");
    Console.WriteLine("\t1. Animated");
    Console.WriteLine("\t2. Drama");
    Console.WriteLine("\t3. Horror");
    Console.WriteLine("\t4. Sci-Fi");
    Console.WriteLine("\t5. All Categories");
    Console.WriteLine();
    Console.Write("Your Category Choice: ");
    string userChoice = Console.ReadLine();

    string animatedPattern = "[aA][niNI]";
    string dramaPattern = "[dD][raRA]";
    string horrorPattern = "[hH][orOR]";
    string sciFiPattern = "[sS][ciCI]";
    string allCatPattern = "[aA][llLL]";
    if (Regex.IsMatch(userChoice, animatedPattern) || userChoice == "1")
    {
        PrintCategory(movies, "Animated");
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (Regex.IsMatch(userChoice, dramaPattern) || userChoice == "2")
    {
        PrintCategory(movies, "Drama");
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (Regex.IsMatch(userChoice, horrorPattern) || userChoice == "3")
    {
        PrintCategory(movies, "Horror");
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if (Regex.IsMatch(userChoice, sciFiPattern) || userChoice == "4")
    {
        PrintCategory(movies, "Sci-Fi");
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else if(Regex.IsMatch(userChoice, allCatPattern) || userChoice == "5")
    {
        PrintAllMovies(movies);
        PauseAndClearScreen();
        runningProgram = WannaRestart();
    }
    else
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
        Console.ResetColor();
        PauseAndClearScreen();
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Thank you for using the Student Database Program!");
Console.WriteLine("Goodbye...");
Console.ResetColor();

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
static void PrintCategory(List<Movie> movies, string category)
{
    List<Movie> tempList = new List<Movie>();
    Console.WriteLine();
    Console.WriteLine($"The {category} movies available are:");
    Console.WriteLine();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
    Console.Write(String.Format("{0,3}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,17}", "Title"));
    Console.ResetColor();
    Console.Write(String.Format("{0,15}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,2}{1,15}", "", "Run Time (Minutes)"));
    Console.ResetColor();
    Console.Write(String.Format("{0,3}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,23}", "Release Date"));
    Console.ResetColor();
    Console.Write(String.Format("{0,12}", "|"));
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
    for (int i = 0; i < movies.Count; i++)
    {
        if (movies[i].Category == $"{category}")
        {
            tempList.Add(movies[i]);
        }
    }
    for (int j = 0; j < tempList.Count; j++)
    {
        if (j % 2 == 0)
        {
            Console.Write(String.Format("{0,3}", "|"));
            Console.Write(String.Format("{0,30}", tempList[j].Title));
            Console.Write(String.Format("{0,2}", "|"));
            Console.Write(String.Format("{0,13}", tempList[j].RunTimeInMinutes));
            Console.Write(String.Format("{0,10}", "|"));
            Console.Write(String.Format("{0,33}", tempList[j].YearReleased.ToString("dddd, MMMM dd, yyyy")));
            Console.Write(String.Format("{0,2}", "|"));
            Console.WriteLine();
        }
        else
        {
            Console.Write(String.Format("{0,3}", "|"));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,30}", tempList[j].Title));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(String.Format("{0,2}", "|"));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,13}", tempList[j].RunTimeInMinutes));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(String.Format("{0,10}", "|"));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,33}", tempList[j].YearReleased.ToString("dddd, MMMM dd, yyyy")));
            Console.ResetColor();
            Console.Write(String.Format("{0,2}", "|"));
            Console.WriteLine();
        }
    }
    Console.ResetColor();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
}
static void PrintAllMovies(List<Movie> movies)
{
    Console.WriteLine();
    Console.WriteLine("All of the movies available in this database are:");
    Console.WriteLine();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
    Console.Write(String.Format("{0,3}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,17}", "Title"));
    Console.ResetColor();
    Console.Write(String.Format("{0,15}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,2}{1,15}", "", "Run Time (Minutes)"));
    Console.ResetColor();
    Console.Write(String.Format("{0,3}", "|"));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(String.Format("{0,23}", "Release Date"));
    Console.ResetColor();
    Console.Write(String.Format("{0,12}", "|"));
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
    for (int i = 0; i < movies.Count; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(String.Format("{0,3}", "|"));
            Console.Write(String.Format("{0,30}", movies[i].Title));
            Console.Write(String.Format("{0,2}", "|"));
            Console.Write(String.Format("{0,13}", movies[i].RunTimeInMinutes));
            Console.Write(String.Format("{0,10}", "|"));
            Console.Write(String.Format("{0,33}", movies[i].YearReleased.ToString("dddd, MMMM dd, yyyy")));
            Console.Write(String.Format("{0,2}", "|"));
            Console.WriteLine();
        }
        else
        {
            Console.Write(String.Format("{0,3}", "|"));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,30}", movies[i].Title));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(String.Format("{0,2}", "|"));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,13}", movies[i].RunTimeInMinutes));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(String.Format("{0,10}", "|"));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0,33}", movies[i].YearReleased.ToString("dddd, MMMM dd, yyyy")));
            Console.ResetColor();
            Console.Write(String.Format("{0,2}", "|"));
            Console.WriteLine();
        }
    }
    Console.ResetColor();
    Console.WriteLine(String.Format("{0,2}{1,0}", "", "-------------------------------------------------------------------------------------------"));
}