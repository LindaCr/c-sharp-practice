﻿using System;

namespace NumberGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");

            Console.WriteLine();

			//start the game
			String choice = "y";
			while (choice.Equals("y"))
			{

				Console.WriteLine("I'm thinking of a number from 1 to 100. Try to guess it!");

                Console.WriteLine();
				int count = 0;
				int guess = 0;

				Random rand = new Random(101);
				int number = rand.Next(1, 101);

				while (guess != number)
				{
                    Console.WriteLine("Enter a number: ");
					guess = Convert.ToInt32(Console.ReadLine());
					count++;
					int diff = guess - number;
					if (diff < -10)
					{
                        Console.WriteLine("Way too low!");
					}
					else if (diff < 0)
					{
                        Console.WriteLine("Too low.");
					}
					else if (diff > 10)
					{
                        Console.WriteLine("Way too high!");
					}
					else if (diff > 0)
					{
                        Console.WriteLine("Too high.");
					}
				}

				printWinner(count);
                Console.WriteLine(); 
				//call method from below main method
				choice = getRequiredString("Try Again? y/n", "y", "n");


			}

            Console.WriteLine();
            Console.WriteLine("Peace");
		}
		private static void printWinner(int count)
		{
            Console.WriteLine("You got it in " + count + " tries.");
			if (count <= 3)
			{
                Console.WriteLine("Great job! You are awesome!");
			}
			else if (count <= 7)
			{
                Console.WriteLine("Not too bad! You have some potential!");
			}
			else
			{
                Console.WriteLine("What took you so long?");
			}
		}


		private static Random getRandomNumber(int limit)
		{
			Random rand = new Random(101);
			return rand;
		}


		private static String getRequiredString(String prompt,
												String s1, String s2)
		{
			String str = "";
			bool isValid = false;
			while (!isValid)
			{
                Console.WriteLine(prompt);
				str = Console.ReadLine().ToLower();
				if (!str.Equals(s1) && !str.Equals(s2))
				{
                    Console.WriteLine("Invalid Entry, try again.");
				}
				else
				{
					isValid = true;
				}
			}

			return str;
		
		}
	}
    
}
