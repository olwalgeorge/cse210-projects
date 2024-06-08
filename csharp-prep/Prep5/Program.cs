using System;

class Program
/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 5
/// This program demonstrate creation and calling of static functions
/// </summary>
/// <comments>
/// The program uses satic void function to display welcome message
/// The user is asked for usename by a static string function which returns capitalized name as string
/// The user is asked for their favorite number by a static int function which returns the sqaure of the numer as an int
/// The capitalized username and square are then displayed
/// <comments>

{
    static void Main(string[] args)
    {
        static void DisplayWelcome (string welcomeMessage)
        {
            Console.WriteLine(welcomeMessage);
        }

        static string PromptUserName (string promptMessage)
        {
            Console.Write(promptMessage);
            string userName = Console.ReadLine();
            return $"{char.ToUpper(userName[0])}{userName.Substring(1)}";
        }

        static int PromptUserNumber(string promptMessage)
        {
            Console.Write(promptMessage);
            int userNumber = int.Parse(Console.ReadLine());                        
            return userNumber*userNumber;
        }

        DisplayWelcome("Welcome to the Program!");
        string capitalizedUserName = PromptUserName("Please enter your name: ");
        int square = PromptUserNumber("Please enter your favorite number: ");

        Console.WriteLine($"Brother {capitalizedUserName}, the square of your number is {square}"); 
        // can use DisplayWelcome($"Brother {userName}, the square of your number is {square}")       

    }
}