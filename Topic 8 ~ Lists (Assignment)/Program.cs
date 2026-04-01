namespace Topic_8___Lists__Assignment_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Reading in Colors";

            Console.ForegroundColor = ConsoleColor.Red;

            Random generator = new Random();

            int num;

            List<string> colors = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input a color: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string color = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();
            Console.Write($"{colors[0]}, {colors[1]}, {colors[2]}, {colors[3]}, {colors[4]}");
            num = generator.Next(6);
            Console.WriteLine();
            Console.WriteLine($"{colors[num]} is the color that suits you the most!!");
        }

        public static void Assignment2()
        {
            Console.Title = "Random Numbers";

            int num, generated, min, max, repeatedNum;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many numbers do you need? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What is the minimum value? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What is the maximum value? \nInput: ");
            Console.ForegroundColor = ConsoleColor.Green;
            max = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Random generator = new Random();
                generated = generator.Next(min, max + 1);
                numbers.Add(generated);
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your numbers are: ");
                Console.Write($"{numbers[i]}");
            }

            Console.WriteLine($"Pick a number between {min} and {max}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            repeatedNum = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < numbers.Count; i++)
            {
                

            }

        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 8 - Lists (Assignment)";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Programming Assignment ");

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