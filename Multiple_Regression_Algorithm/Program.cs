
namespace Multiple_Regression_Algorithm
{
    public static class Gauss
    {
        static void Main(string[] args)
        {
            //int numVariables = InputHandler.GetAndValidateVariableInput();
            //string file = InputHandler.GetAndValidateFilePathInput();

            string filePath = "Test_Data_4.txt";

            // Read data from the file and executing the algorithm
            double[] result = MultipleRegression.RegressionAlgorithmFromFile(filePath);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("\x1b[38;5;0045mB" + i + ": " + result[i] + "\x1b[38;5;0015m");
            }
        }
    }
}
