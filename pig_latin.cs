
using System;
using System.Collections.Generic;

namespace piglatin{
    public class HelloWorld
{ 
        public static void pig_latin() 
        {  
            Console.WriteLine("Enter words");
            string words = Console.ReadLine();
            string[] word = words.Split(" ");
            foreach(var st in word){
                var rt = st[1..];
                var et = st[0];
                Console.WriteLine($"{rt}{et}ay");
            }
        }
         public static void latin_pig() 
        {
            Console.WriteLine("Enter words");
            string words = Console.ReadLine();
            string[] word = words.Split(" ");
            foreach(string st in word){
                string remove_ay = st.Remove(st.Length -2 );
                char last_char = remove_ay[remove_ay.Length-1];
                string final_word = st.Remove(st.Length -3 );
                
                Console.WriteLine(last_char+final_word);
            }
        }

    public static void Main(string[] args)
    {   
        pig_latin();
        Console.WriteLine("\n");
        latin_pig();
        

     
    }
}

}
