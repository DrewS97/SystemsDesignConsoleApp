using System;

namespace SystemsDesignConsoleApp{
    public class Menus{
        //Printing the menu
        public static void Menu()
        {
            Console.WriteLine("Welcome to your personal computer assistant. =)");
            Console.WriteLine("[1] Enter '1' for a custom greeting!");
            Console.WriteLine("[2] Enter '2' to calculate the area of a rectangle.");
            Console.WriteLine("[3] Enter '3' to calculate your Miles Per Gallon.");
            Console.WriteLine("[4] Enter '4' to search a phrase in the first sentence of Alice's Adventures in Wonderland.");
            Console.WriteLine("[q] Enter 'q' to quit.");
            Console.WriteLine("Please enter an option:");
            MenuUse();
        }

        //Menu Functionality
        public static void MenuUse()
        {
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "1":
                    GreetMe();
                    break;
                case "2":
                    CalcRectangle();
                    break;
                case "3":
                    CalcMPG();
                    break;
                case "4":
                    Alice();
                    break;
                case "q":
                    Console.WriteLine("\nI hope we helped solve your problem! =)");
                    break;
                default:
                    Console.WriteLine($"\nPlease enter either \"1\", \"2\", \"3\", \"4\" or \"q\".\n");
                    break;
            }
            if(answer != "q")
            {
                Menu();
            }
        }

        //Option 1
        public static void GreetMe()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello there, {name} I hope that you're doing well today!\n");
        }

        //Option 2
        public static void CalcRectangle()
        {
            Console.WriteLine("\nEnter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = height * width;
            Console.WriteLine($"\nThe area of your rectangle is {area}\n");
        }

        //Option 3
        public static void CalcMPG()
        {
            Console.WriteLine("How many miles have you driven?");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you consumed?");
            double gallons = Convert.ToDouble(Console.ReadLine());

            double mpg = miles / gallons;
            Console.WriteLine($"\nYour car gets approximately {mpg} MPG\n");
        }

        //Option 4
        public static void Alice()
        {
            string story = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do:" +
            "once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Enter a phrase to search: ");
            string answer = Console.ReadLine();

            bool alice = story.Contains(answer);
            Console.WriteLine($"\nIt is {alice} that {answer} is contained in the opening sentence to Alice's Adventures in WonderLand\n");
        }
    }

}