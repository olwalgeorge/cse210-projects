using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        
        int guess = 0;
        int attempts = 0;
        while(guess != magicNumber)
            {
                attempts++;
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());                    
                }
                if(guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }  
                else if(guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }  
                
            }
        Console.WriteLine($"You guessed it! It took you {attempts} guesses");
        Console.Write("Do you want to continue with the game? ");
        string answer = Console.ReadLine();
        if(answer == "y")
            {   
                Main(args);

            }  
        else
            {
                Console.WriteLine("Goodbye");
            }
    }


}