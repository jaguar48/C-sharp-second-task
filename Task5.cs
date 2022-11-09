using System;
using System.Collections.Generic;					
public class Register
{   
    
class Person
{
  public string Name  // property
  { get; set; }
  
   public string Email  // property
  { get; set; }
  
  public int Password  // property
  { get; set; }
}

class User
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    Console.WriteLine("Enter name");
    var enter_name = Console.ReadLine();
    Console.WriteLine("Enter Email");
    var enter_email = Console.ReadLine();
    Console.WriteLine("Enter Password");
    int enter_pass = int.Parse(Console.ReadLine());
    
    myObj.Name = enter_name;
    myObj.Email = enter_email;
    myObj.Password = enter_pass;
        
    Console.WriteLine("Registration successful");
    
    Console.WriteLine("let's login");
    Console.WriteLine("enter_name");
    var enter_Name = Console.ReadLine();
    Console.WriteLine("enter_Password");
    int enter_Pass = int.Parse(Console.ReadLine());
    
    if (enter_Name == myObj.Name & enter_Pass == myObj.Password ){
         Console.WriteLine("login successful");
    }
    
    else{
        Console.WriteLine("login incorrect");
    }
  }
}
}