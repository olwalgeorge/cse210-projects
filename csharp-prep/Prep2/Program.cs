using System;
using System.Runtime.InteropServices;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int studentMarks = int.Parse(Console.ReadLine());
        
        string letter;
        if(studentMarks >= 90)
            {
                letter = "A";
            }
        else if(studentMarks >= 80)
            {
                letter = "B";
            }
        else if(studentMarks >= 70)
            {
                letter = "C";
            }
        else if(studentMarks >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }
        string suffix="";
        if(studentMarks % 10 >= 7 && letter != "A")
        
            {
                suffix = "+";
            }
        else if(studentMarks % 10 < 3 && letter != "F")
            {
                suffix = "-";
            }   


        if(studentMarks>=70)
            { 
                Console.WriteLine($"Congratulations! You passed with a grade of {letter}{suffix}");
            }
        else
            {
                Console.WriteLine($"Sorry, you failed with a grade of {letter}{suffix}. Put more effots in your next try");
            }
        
    }
    
}