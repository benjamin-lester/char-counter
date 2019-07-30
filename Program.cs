using System;
using System.Collections.Generic;
using System.Linq;

namespace MUFA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the letter tally program.");
            Console.WriteLine("I will compute the most common letter in your text (not case sensitive)");
            Console.WriteLine("Please input your text:");
            string userWords = Console.ReadLine();
            Console.WriteLine("Thanks! Now, which letter shall I count: ");
            char askedForChar = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("\nYou asked to count " + askedForChar);
            Console.WriteLine("Press any key to continue with the count...");
            Console.ReadKey();
            UserInput userInput1 = new UserInput(userWords,askedForChar);
            
            Console.WriteLine("#### SUMMARY ####");
            Console.WriteLine("Count of character {0}: \t{1}",(char)userInput1.SearchChar,userInput1.CountOfSearchChar);
            Console.WriteLine("That's a wrap.");

            return;
        }
    }
    public class UserInput 
    {
        string userInput;
        public char SearchChar { get; private set; }
        public int CountOfSearchChar { get; private set; }
        public UserInput(string uInput, char sChar) 
        {   
            userInput = uInput;
            SearchChar = sChar;
            CountChars();
        }
        void CountChars() 
        {
            // not case sensitive
            userInput = userInput.ToUpper();
            SearchChar = Char.ToUpper(SearchChar);
            // do the counting
            CountOfSearchChar = userInput.Count(c => c == SearchChar);
        }
    }

}
