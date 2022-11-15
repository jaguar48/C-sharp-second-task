
using System;
using System.Collections.Generic;
public class HelloWorld
{ 
        public static void pig_latin(string words) 
        {
            string[] word = words.Split(" ");
            foreach(var st in word){
                var rt = st[1..];
                var et = st[0];
                Console.WriteLine($"{rt}{et}ay");
            }
        }
         public static void latin_pig(string words) 
        {
            
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
        pig_latin("The quick brown fox");
        Console.WriteLine("\n");
        latin_pig("heTay uickqay rownbay oxfay");
        

     
    }
}
