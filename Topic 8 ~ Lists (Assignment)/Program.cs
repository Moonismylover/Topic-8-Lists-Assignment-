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
            Console.Write($"{colors[0]}, {colors[1]}, {colors[2]}, {colors[3]}, {colors[4]}");
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

            Console.WriteLine(" ");
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
                    Console.WriteLine("Your number appears " + occurances + " times in the list.");
                }
                else
                    Console.WriteLine("Your number does not appear in the list.");
            }

            Console.WriteLine();
            Console.WriteLine("I will now replace a number of your choice with ZERO!");
            Console.WriteLine("What number would you like to replace: ");
            Console.ForegroundColor = ConsoleColor.Green;
            replace = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (replace == numbers[i])
                {
                    numbers[i] = 0;
                }
                else
                    Console.WriteLine("That number never appeared in the List, so nothing was replaced.");
            }

            Console.WriteLine();
            Console.WriteLine("Here's a printed version of the list once again!");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Now I will reset all the values in the list to zero!");
            
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Here's a printed version of the list once again!");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("I will now fill the list again with new random numbers!");

            for (int i = 0; i < num; i++)
            {
                generated = generator.Next(min, max + 1);
                numbers.Add(generated);
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



/**
Lists Programming Assignments

Create a single Console (.NET Framework) program and include the following assignments in it. Make
sure to label each part using comments and an appropriate WriteLine() statement.
Programming Assignment 1 – Reading in Colors
Create a program that uses a For Loop to read in 5 colors and store it in a List of strings. Print all
elements in the List on the same line, separated by a comma. Generate a random number and use that
number to print out a random color from the List.
Programming Assignment 2 – Random Numbers
Create a List of integers. Asks the user to enter how many numbers they need. Next, ask the user for a
maximum and minimum value. Use a for loop to fill the List with random values within that range
(inclusive). Once the List is filled with values, do the following using a separate loop for each (make sure
to include an explanatory message for each part):
1. Print the List to the screen on one line.
2. Prompt the user for a number and count the number of times that number appears in the List.
a. Display the number of times that number appeared in a formatted
Console.WriteLine() statement.

3. Prompt the user for a number and replace all occurrences of that number with zero.
4. Print the List to the screen on one line.
5. Using a loop, reset each value in the List with zeros.
6. Print the List to the screen on one line.
7. Use a loop to fill the List again with new random numbers.
8. Print the List to the screen on one line.
**/