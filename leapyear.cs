

using System;
namespace leapyear{
    public class HelloWorld
{
    
    public static void calcleap(){
        int year, count= 0;
        Console.WriteLine("Enter year");
        
        year = int.Parse(Console.ReadLine());
        
        while (count<20){
            year ++;
            if ((year %4 ==0 )|| (year % 400 ==0)){
                Console.WriteLine("year" + year + "is a leap year");
                count ++;
            }
            
        }
    }
    public static void Main(string[] args)
    {
        calcleap();
    }
}
}
