using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soleran.CodeTherapy.Naming.PalendromChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            var checker = new PalindromeChecker();

            var input = string.Empty;

            // Act
            while (!IsCommand(input))
            {
                input = PromptUserInput();
                
                var result = checker.Check(input);

                WriteResult(input, result);
            }

        }

        public static string PromptUserInput()
        {
            Console.WriteLine("Enter a word to see if its a palendrome -- or type quit to quit");

            return Console.ReadLine();
        }

        public static void WriteResult(string input, bool result)
        {
            var output = IsCommand(input) ? "Goodbye! \n" : $"Palendrome: {result} \n";

            Console.WriteLine(output);
        }

        public static bool IsCommand(string input) => input.Equals("quit", StringComparison.OrdinalIgnoreCase);


    }
}
