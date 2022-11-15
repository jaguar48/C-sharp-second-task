// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Linq;



public class HelloWorld
{
    public static string NumberToWords(int number)
{
        if (number == 0)
            return "zero";
    
        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));
    
        string words = "";
    
        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }
    
        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }
    
        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }
    
        if (number > 0)
        {
            if (words != "")
                words += "and ";
    
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    
            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }   
Console.WriteLine(words);
    return words;
}


    private static Dictionary<string, long> numberTable = new Dictionary<string, long>{  
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},  
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},  
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},  
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},  
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},  
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},  
        {"billion",1000000000},{"trillion",1000000000000},{"quadrillion",1000000000000000},  
        {"quintillion",1000000000000000000}  
    };  
  
    public static long ConvertToNumbers(string numberString)  
    {  
        var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()  
                .Select(m => m.Value.ToLowerInvariant())  
                .Where(v => numberTable.ContainsKey(v))  
                .Select(v => numberTable[v]);  
        long acc = 0, total = 0L;  
        foreach (var n in numbers)  
        {  
            if (n >= 1000)  
            {  
                total += acc * n;  
                acc = 0;  
            }  
            else if (n >= 100)  
            {  
                acc *= n;  
            }  
            else acc += n;  
        }  
        return (total + acc) * (numberString.StartsWith("minus",  
                StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);  
       
    }  

    public static void Main(string[] args)
    
    {       Console.WriteLine("Choose 1 for words and 2 for number");
            var choose_option = Console.ReadLine();
            if (choose_option =="1"){
                 NumberToWords(29);
            }
            else if (choose_option =="2"){
                 Console.WriteLine(ConvertToNumbers("five"));
            }
            
          
    }
}