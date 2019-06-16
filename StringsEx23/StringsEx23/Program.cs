using System;

namespace StringsEx23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write whatever crosses your mind in the next 5 seconds.");

            string givenString = Console.ReadLine();
            DisplayUpperAndLowerCases(givenString);
        }

        //Write a method that takes input from the user and displays that input back in upper and lower cases.

        public static void DisplayUpperAndLowerCases(string input)
        {
            Console.WriteLine("Now, we will present to you what you wrote in upper and lower cases: \n {0} \n{1}", input.ToUpper(), input.ToLower());
        }
    }
}
