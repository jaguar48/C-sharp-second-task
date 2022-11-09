using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       while (true){
         Console.WriteLine("enter c for charp, o for .net book, d for clean coding, e for EF core book");
         var get_userinput = Console.ReadLine();
         
         if (get_userinput == "c"){
            Console.WriteLine("Yoh read sam teach yourself csharp in 1 day");
         }
         else if (get_userinput == "o"){
            Console.WriteLine("Yoh .Net core book is available");
         }
         else if (get_userinput == "d"){
            Console.WriteLine("Yoh clean coding book is available");
         }
         else if (get_userinput == "e"){
            Console.WriteLine("Yoh EF core book is available");
         }
         else{
            Console.WriteLine("sorry this book is not available");
            break;
         }
       }
       
    }
}
