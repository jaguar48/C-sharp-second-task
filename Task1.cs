
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   var holdhash = "";
        Console.WriteLine("Enter favourite strings");
        var CharTransform = Console.ReadLine();
        var Newstring = CharTransform[^4..];
        
        for(int i=0 ;i<= CharTransform.Length-4;i++){
            holdhash += "#";
        }
        var updated_str = holdhash + Newstring;
        
         Console.WriteLine(updated_str);
        
    }
}
