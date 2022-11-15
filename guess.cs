using System;
using System.Collections.Generic;					
public class Program
{
    
        static int Gennum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }

        public static void myguess (){

            int rand_num = Gennum(1,5);
    		int user_tries = 0;
    		
            var user_inputs = new List<int>();
    
    	    while (user_tries <= 5)
                {
                   
                    Console.WriteLine("guess from 1-5 numbers ");
                    int enter_number = int.Parse(Console.ReadLine());
                       
                    if (user_inputs.Contains(enter_number))
                    {
                         user_tries -= 1;
                        Console.WriteLine($"consecutive numer {user_tries}");
                        continue;
                        
                    }
    
                    user_inputs.Add(enter_number);
                  
                   	user_tries += 1;
    		
                    if (enter_number < rand_num)
                    {
                        Console.WriteLine($"Mininum");
                    }
    
                    else if (enter_number > rand_num)
                    {
                        Console.WriteLine("Maxmimum ");
                    }
                    else
                    {
                        Console.WriteLine($"that's correct {rand_num}");
                        break;
                    }
    
                    Console.WriteLine($"random number is {rand_num}");
                    Console.WriteLine($" tries count is {user_tries}");
                }
                Console.WriteLine($"Total tries is {user_tries}");
    	}
        
        
	public static void Main()
	{
	    myguess();
	}

}

