using System;

namespace leapchecker{
    public class HelloWorld
{
    
    public class yearcount{
        public int current_year;
        public int count_years ;
        
        public void 
        
        public yearcount(int current, int countYear){
            current_year = current;
            count_years = countYear;
            
             while ( countYear< 20 ){
                current = current +1;
                if ((current % 4 == 0)){
                    countYear++;
                    Console.WriteLine(current);
                }
            }
        }

    }
    public static void Main(string[] args)
    {
        
    yearcount countye = new yearcount(2022,0);
  
    }
}
}

 
