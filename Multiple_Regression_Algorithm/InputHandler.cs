
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

        public static int ValidateVariableInput(string input)
        {
            if (!int.TryParse(input, out int numVariables))
            {
                PrintErrorMessage("Invalid input. Please enter a whole number.");
                return -1;
            }

            if (int.Parse(input) < 2)
            {
                PrintErrorMessage("Invalid input. Please enter a number equal or greater than 2.");
                return -1;
            }

            return numVariables;
        }

        public static string? ValidateFilePathInput(string input)
        {
            if (Path.GetExtension(input) != ".txt")
            {
                PrintErrorMessage("Invalid or missing file format. Only .txt files are supported.");
                return null;
            }

            if (!File.Exists(input))
            {
                PrintErrorMessage("File does not exist. Please enter a valid file path.");
                return null;
            }

            return input;
        }
    }
}
