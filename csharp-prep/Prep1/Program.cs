using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        string capitalizedFirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        string capitalizedLastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
        
        Console.Write($"Your name is {capitalizedLastName}, {capitalizedFirstName} {capitalizedLastName}.");
        


    }
}