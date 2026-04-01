namespace Topic_8___Lists__Assignment_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Reading in Colors";

            Console.ForegroundColor = ConsoleColor.Red;

            int num;

            Random generator = new Random();

            List<string> colors = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Input a color: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string color = Console.ReadLine();
                colors.Add(color);
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();
            
            for (int i = 0; i < colors.Count; i++)
            {
                Console.Write(colors[i]);
                if (i < colors.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            num = generator.Next(colors.Count);
            Console.WriteLine();
            Console.WriteLine($"{colors[num]} is the color that suits you the most!!");
        }

        public static void Assignment2()
        {
            Console.Title = "Random Numbers";

            int num, min, max, generated, repeatedNum, occurances = 0, replace;

            Random generator = new Random();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("How many numbers do you need? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("What is the minimum value? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("What is the maximum value? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            max = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < num; i++)
            {
                generated = generator.Next(min, max + 1);
                numbers.Add(generated);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your numbers in the list include the following...");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's see how many times a specific number appears in the list!");
            Console.WriteLine($"Pick a number between {min} and {max}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            repeatedNum = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (repeatedNum == numbers[i])
                {
                    occurances++;
                }
            }
            Console.WriteLine("Your number appears " + occurances + " times in the list.");
    
            Console.WriteLine();
            Console.WriteLine("I will now replace a number of your choice with ZERO!");
            Console.WriteLine("What number would you like to replace: ");
            Console.ForegroundColor = ConsoleColor.Green;
            replace = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            bool found = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (replace == numbers[i])
                {
                    numbers[i] = 0;
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("That number never appeared in the List, so nothing was replaced.");
            }

            Console.WriteLine();
            Console.WriteLine("Here's a printed version of the list once again!");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now I will reset all the values in the list to zero!");
            
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }

            Console.WriteLine("Here's a printed version of the list once again!");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I will now fill the list again with new random numbers!");
            Console.WriteLine("Your new numbers are: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = generator.Next(min, max + 1);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 8 - Lists (Assignment)";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~ Reading in Color ~~~~~~~~~~~~~~~~~~~~~~~~~");
            Assignment1();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~ Random Numbers ~~~~~~~~~~~~~~~~~~~~~~~~~");
            Assignment2();
            Console.WriteLine();

        }
    }
}