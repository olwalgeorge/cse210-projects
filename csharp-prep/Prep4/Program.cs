using System;
using System.Runtime.InteropServices;

class Program
/// <Author>
/// George Olwal
/// </Author>
/// <Summary>
/// C# Prep 4
/// This program will ask the user to enter a list of numbers frm console then calculates sum, average, largest number, positive smallest number and sort the list
/// </Summary>
/// <remarks>
/// The program utilizes do while loop to ask user for numbers and add them to a list.
/// The program uses if conditional statement to get and largest and positive smallest number which had beed declared to negative infinity and positive infinity respectively. 
/// The sum is calculated by iterative additions.
/// The average is calculated by dividing the sum by the length of the list  
/// The program displays list numbers, sum, average, largest number, smallest positive number
/// The sorted list is calculated and displayed
/// </remarks>
{
    static void Main(string[] args)
    {
        int num; 
        int sum = 0;
        double max = double.NegativeInfinity;  
        double min = double.PositiveInfinity;     
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }

            sum += num;

            if (num > max)
            {
                max = num;
            }
            if (num<min && num>0)
            {
                min = num;
            }
            
            
        } while (num != 0);
        
        
        double average = (double)sum / numbers.Count;
        
        Console.WriteLine("List of numbers"); 
          
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}"); 
        Console.WriteLine($"The smallest positive number is: {min}");  
        
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
}





   
