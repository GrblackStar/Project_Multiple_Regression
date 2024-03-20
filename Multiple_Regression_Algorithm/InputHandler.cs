using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Regression_Algorithm
{
    public class InputHandler
    {
        public static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static int GetAndValidateVariableInput()
        {
            int numVariables = 0;

            while (true)
            {
                Console.WriteLine("Enter the number of independent variables: ");
                string numInput = Console.ReadLine();

                if (!int.TryParse(numInput, out numVariables))
                {
                    PrintErrorMessage("Invalid input. Please enter a whole number.");
                    continue;
                }

                if (int.Parse(numInput) < 2)
                {
                    PrintErrorMessage("Invalid input. Please enter a number equal or greater than 2.");
                    continue;
                }

                numVariables = int.Parse(numInput);
                return numVariables;
            }
        }

        public static string GetAndValidateFilePathInput()
        {
            string filePath = "";
            
            while (true)
            {
                Console.WriteLine("Enter the path to the data file: ");
                filePath = Console.ReadLine();

                if (Path.GetExtension(filePath) != ".txt")
                {
                    PrintErrorMessage("Invalid or missing file format. Only .txt files are supported.");
                    continue;
                }

                if (!File.Exists(filePath))
                {
                    PrintErrorMessage("File does not exist. Please enter a valid file path.");
                    continue;
                }

                return filePath;
            }
        }
    }
}
