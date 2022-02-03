using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
        //1. Write a C# Sharp program to print Hello and your name in a separate line.
		    Console.WriteLine("Hello");
		    Console.WriteLine("Adelaide");
		
		//2. Write a C# Sharp program to print the sum of two numbers.
		    int sum = 7 + 7;
		    Console.WriteLine(sum);
		
		//3. Write a C# Sharp program to print the result of dividing two numbers.
		    	//for int
		    int divide = 10 / 2;
		    Console.WriteLine(divide);
		    	//for double
		    double dividee = 12.5 / 3;
		    Console.WriteLine(dividee);
		
		//4. Write a C# Sharp program to print the result of the specified operations.
		    	//for int
		    int total = 7 + 8 / 2;
		    Console.WriteLine(total);
		    	//for double
		    double totaal = 8.1 + 7 / 2;
		    Console.WriteLine(totaal);
		
		//5. Write a C# Sharp program to swap two numbers.
	    	int temp;
		
	    	Console.Write("Enter the first number - ");
	    	int firstNum = int.Parse(Console.ReadLine());
		
	    	Console.Write("Enter the second number - ");
		    int secondNum = int.Parse(Console.ReadLine());
		
		    Console.WriteLine("I would like to swap the numbers.");
		    temp = firstNum;
		    firstNum = secondNum;
		    secondNum = temp;
		
		    Console.WriteLine("Due to the swapping made, your first number is - {0}", firstNum);
		    Console.WriteLine("Due to the swapping made, your first number is - {0}", secondNum);
		    
		        }
    }
}
