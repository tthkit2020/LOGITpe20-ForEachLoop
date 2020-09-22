using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user's name 
             and displays the length of the name
            without using the Length property*/
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine();
            int counter = 0;

            foreach(char letter in userInput)
            {
                //Console.WriteLine(letter);
                counter = counter + 1;
                Console.WriteLine($"letter {letter} is at {counter}");
            }

            Console.WriteLine($"Your name is {counter} characters long.");
        }
    }
}
