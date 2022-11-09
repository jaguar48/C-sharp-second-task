using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string testing = "texT thaN i Am lOoking for".Trim();
        
        
        foreach(char test in testing){
          if(char.IsUpper(test)){
              Console.WriteLine(testing.IndexOf(test));
          }
        }
        
        
       
    }
}
