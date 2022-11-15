// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;




public class HelloWorld
{
 
    
        public static void codecracker(){
                 Dictionary<string, string> My_dict2 =  new Dictionary<string, string>(){
                    
                {
                "a",
                "£"},
            {
                "b",
                "*"},
            {
                "c",
                "%"},
            {
                "d",
                "&"},
            {
                "e",
                ">"},
            {
                "f",
                "<"},
            {
                "g",
                "!"},
            {
                "h",
                ")"},
            {
                "i",
                "\""},
            {
                "j",
                "("},
            {
                "k",
                "@"},
            {
                "l",
                "a"},
            {
                "m",
                "b"},
            {
                "n",
                "c"},
            {
                "o",
                "d"},
            {
                "p",
                "e"},
            {
                "q",
                "f"},
            {
                "r",
                "g"},
            {
                "s",
                "h"},
            {
                "t",
                "i"},
            {
                "u",
                "j"},
            {
                "v",
                "k"},
            {
                "w",
                "l"},
            {
                "x",
                "m"},
            {
                "y",
                "n"},
            {
                "z",
                "o"}};
                
            
                
                 while (true){
                     var encrypt = "";
                     Console.WriteLine("enter message");
                     var message = Console.ReadLine();
                    
                    foreach (char m in message){
                        var n = m.ToString();
                        
                        encrypt +=My_dict2[n];
                }
                  Console.WriteLine(encrypt);
            }
    }
 
    public static void Main(string[] args)
    {
       codecracker();
         
    }

}