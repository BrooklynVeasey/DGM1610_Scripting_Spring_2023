using System;

namespace HelloWorld
{
  class Program
  {

    static void Main(string[] args)
    {
      // [data-type] [identifier] [assignment operator] [value]
   		// Variable Declaration
 	   
    	int age = 42;
  		float height = 6.25f;
  		double weight = 350.45d;
  	 	string nameFirst = "George";
	  	char middleInitial = 'L';
	  	string nameLast = "Brown";
   		bool alive = true;
      int day = 12;
      bool attended = true;
      char gender = 'M';
        
      weight = 250.67d;
        
     	Console.WriteLine(age);    
     	Console.WriteLine(height);   
     	Console.WriteLine(weight);   
     	Console.WriteLine(nameFirst);   
     	Console.WriteLine(middleInitial);
      Console.WriteLine(nameLast);  
    	Console.WriteLine(alive);  
      Console.WriteLine(day);         
      Console.WriteLine(attended); 
      Console.WriteLine(gender);  
    }
  }
}
