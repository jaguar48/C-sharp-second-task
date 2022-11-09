
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter date string in this format 09/March/2021");
        string inputDate = Console.ReadLine();
        Datefunction(inputDate);
        Console.ReadLine();
    }
    static void Datefunction (string inputDate){
        try{
            DateTime outputDate = DateTime.Parse(inputDate);
            outputDate = outputDate.AddDays(7);
            Console.WriteLine(outputDate.ToString("dd/MMMM/yyyy"));
        
        }
        catch (FormatException){
            Console.WriteLine("Unable to parse the specified date");
        }
    }
}