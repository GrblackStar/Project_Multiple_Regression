namespace Multiple_Regression_Algorithm
{
    public static class Gauss
    {
        static void Main(string[] args)
        {
            // CHECK HOW MANY INDEPENDENT VARIABLES ARE INPUTED... MUST BE MORE THAN 2
            // CHECK THE FILE HANDLING
            //int a = int.Parse(Console.ReadLine());
            //int[] ints = new int[a];
            Console.WriteLine("Current working directory: " + Environment.CurrentDirectory);
            Console.WriteLine("Enter the number of independent variables: ");
           // int numIndependentVars = int.Parse(Console.ReadLine());
            // HARDCODED -------->>>>>>>>>>>>>>>> REMOVE LATER
            int numIndependentVars = 6;

            Console.WriteLine("Enter the path to the data file: ");
            //string filePath = Console.ReadLine();
            // HARDCODED -------->>>>>>>>>>>>>>>> REMOVE LATER
            string filePath = "Test_Data_1.txt";

            // Read data from the file
            double[] result = RegressionAlgorithmFromFile(filePath);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static double[] RegressionAlgorithmFromFile(string filePath)
        {
            double[][] inputData = ReadDataFromFile(filePath);
            return RegressionAlgorithm(inputData, inputData[0].Length, inputData.Length);
        }

        // Function to perform Gaussian elimination and back substitution
        public static double[] RegressionAlgorithm(double[][] data, int numberOfVariables, int numberOfSamples)
        {
            // Solve the linear equations using the sums
            double[][] matrix = new double[numberOfVariables][];
            for (int i = 0; i < numberOfVariables; i++)
            {
                int currentVariable = i - 1;
                double[] row = new double[numberOfVariables + 1];
                if (i == 0)
                {
                    row[0] = numberOfSamples;
                }
                else
                {
                    double sum = 0;
                    for (int s = 0; s < numberOfSamples; s++)
                    {
                        sum += data[s][currentVariable];
                    }
                    row[0] = sum;
                }

                for (int c = 0; c < numberOfVariables; c++)
                {
                    double sum = 0;
                    for (int s = 0; s < numberOfSamples; s++)
                    {
                        double currentVarSample = i == 0 ? 1 : data[s][currentVariable];
                        sum += data[s][c] * currentVarSample;
                    }
                    row[c + 1] = sum;
                }

                matrix[i] = row;
            }

            ////////   TEEEEEEEEEEEEEEEEEEEEEEESSSSSSSSSSSSSTTTTTTTTTTTTTTTTTTTT

            // Removal
            for (int v = 0; v < numberOfVariables - 1; v++)
            {
                var varSimplifying = v;
                var firstRow = matrix[v];
                var firstRowValue = firstRow[varSimplifying];

                for (int r = v + 1; r < matrix.Length; r++)
                {
                    var myRow = matrix[r];
                    var targetValue = myRow[varSimplifying];
                    double coeff = targetValue / firstRowValue;

                    for (int c = 0; c < firstRow.Length; c++)
                    {
                        myRow[c] = myRow[c] - (firstRow[c] * coeff);
                    }
                }
            }

            // Backtrack
            double[] resultCoeff = new double[numberOfVariables];
            for (int i = 0; i < resultCoeff.Length; i++)
            {
                resultCoeff[i] = 1f;
            }

            for (int i = numberOfVariables - 1; i >= 0; i--)
            {
                var row = matrix[i];

                for (int c = 0; c < resultCoeff.Length; c++)
                {
                    row[c] = row[c] * resultCoeff[c];
                }

                double firstNonZero = 0;
                int firstNonZeroIndex = 0;
                for (int c = 0; c < row.Length; c++)
                {
                    if (row[c] != 0)
                    {
                        firstNonZero = row[c];
                        firstNonZeroIndex = c;
                        break;
                    }
                }

                double target = row[numberOfVariables];
                for (int c = firstNonZeroIndex + 1; c < row.Length - 1; c++)
                {
                    target -= row[c];
                }

                resultCoeff[i] = target / firstNonZero; 
            }

            // Round
            for (int i = 0; i < resultCoeff.Length; i++)
            {
                resultCoeff[i] = Math.Round(resultCoeff[i], 4);
            }

            return resultCoeff;
        }


        public static double[][] ReadDataFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int numEntries = lines[0].Split(',').Length;
            double[][] fileData = new double[numEntries][];
            for (int i = 0; i < numEntries; i++)
            {
                fileData[i] = new double[lines.Length];
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                int lineEntries = values.Length;
                for (int v = 0; v < lineEntries; v++)
                {
                    fileData[v][i] = double.Parse(values[v]);
                }
            }

            return fileData;
        }

    }
}
