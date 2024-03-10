
namespace Multiple_Regression_Algorithm
{
    public static class Gauss
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the data file: ");
            //string filePath = Console.ReadLine();
            // HARDCODED -------->>>>>>>>>>>>>>>> REMOVE LATER
            string filePath = "Test_Data_3.txt";

            // Read data from the file
            double[] result = MultipleRegression.RegressionAlgorithmFromFile(filePath);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("B" + i + ": " + result[i]);
            }
        }
    }
}
