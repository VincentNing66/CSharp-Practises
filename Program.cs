﻿using System;


namespace practise
{
	public class Program
	{
		
		public static void Main()
		{
            Console.WriteLine("This console contains a few different c# fundemental practises");
			Console.WriteLine("follow the menu to choose the one to run!");
            Console.WriteLine("1.CeckoutMachine(getters and setters)");
			Console.WriteLine("2.StudentsN'Teachers(Inheritance&polumorphism&Encapsulation)");
            Console.WriteLine("3.Generics");
            var decision = Console.ReadLine();
            switch (decision)
			{
				case "1":
					CheckoutMachine _checkoutMachine = new CheckoutMachine();
					_checkoutMachine._checkout();
                    break;
				case "2":
                    People _people = new People();
                    _people.peopleMain();
                    break;
				case "3":
                    Generics _generics = new Generics();
                    _generics.GMain();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;
            }


        }
	}
}				
