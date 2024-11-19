using System;

namespace Assignment3._1._3
{
    internal class Program
    {
        // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Write a statement to count the spaces. ");
            string statement = Console.ReadLine();

            int spaceCount = CountSpaces(statement);

            Console.WriteLine($"{statement} contains {spaceCount} spaces.");
        }

        static int CountSpaces(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
