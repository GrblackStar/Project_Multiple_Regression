
namespace Multiple_Regression_Algorithm
{
    public static class Gauss
    {
        static void Main(string[] args)
        {
            //int numVariables = InputHandler.GetAndValidateVariableInput();
            //string file = InputHandler.GetAndValidateFilePathInput();

            int numVariables;
            while (true)
            {
                Console.WriteLine("Enter the number of independent variables: ");
                numVariables = InputHandler.ValidateVariableInput(Console.ReadLine());
                if (numVariables > 0) break;
                else continue;
            }

            string? file;
            while (true)
            {
                Console.WriteLine("Enter the path to the data file: ");
                file = InputHandler.ValidateFilePathInput(Console.ReadLine());
                if (file != null) break;
                else continue;
            }

            string filePath = "Test_Data_3.txt";

            // Read data from the file and executing the algorithm
            double[]? result = MultipleRegression.RegressionAlgorithmFromFile(filePath);
            if (result == null) return;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("\x1b[38;5;0045mB" + i + ": " + result[i] + "\x1b[38;5;0015m");
            }
        }
    }
}
