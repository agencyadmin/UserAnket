using System;
class MainClass
{
	public static void Main(string[] args)
	{

		
	Console.WriteLine("What is your name?");
		String MyName = Console.ReadLine();
		Console.WriteLine("What is your age?");
		Byte MyAge = (byte) int.Parse(Console.ReadLine());
	    Console.WriteLine("Your name is {0} and your age is {1}", MyName, MyAge);
		Console.WriteLine("What is your birthday?");
		String Birthday = Console.ReadLine();
		Console.WriteLine($"Your birthdate is {Birthday}");
	}	
}