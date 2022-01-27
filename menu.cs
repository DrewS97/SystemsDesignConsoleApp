using System;

namespace SystemsDesignConsoleApp{
    public class Menus{
        public static void Menu()
        {
            Console.WriteLine("Welcome to your personal computer assistant. =)");
            Console.WriteLine("[1] Enter '1' for a custom greeting!");
            Console.WriteLine("[2] Enter '2' to calculate the area of a rectangle.");
            Console.WriteLine("[3] Enter '3' to calculate your Miles Per Gallon.");
            Console.WriteLine("[4] Enter '4' to search a phrase in the first sentence of Alice in Wonderland.");
            Console.WriteLine("[q] Enter 'q' to quit.");
            Console.WriteLine("Please enter an option:");
            MenuUse();
        }

        public static void MenuUse()
        {
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "1":
                    GreetMe();
                    break;
                case "2":
                    Console.WriteLine("In Progress. Come back later.");
                    break;
                case "3":
                    Console.WriteLine("In Progress. Come back later.");
                    break;
                case "4":
                    Console.WriteLine("In Progress. Come back later.");
                    break;
                case "q":
                    Console.WriteLine("I hope we helped solve your problem!");
                    break;
                default:
                    Console.WriteLine($"Please enter either \"1\", \"2\", \"3\", \"4\" or \"q\".\n");
                    break;
            }
        }

        public static void GreetMe()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello there, {name} I hope that you're doing well today!");
        }
    }

}