
namespace Multiple_Regression_Algorithm
{
    public class MultipleRegression
    {
        public static string HandleInputFile(string inputFileName)
        {
            return null;
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
            double[][] matrix = ConstructMatrix(data, numberOfVariables, numberOfSamples);

            // Gaussian elimination for reducing a matrix to row-echelon form.
            ReduceMatrixToRowForm(matrix, numberOfVariables);

            // Solving the system of linear equations represented by the row-echelon matrix.
            double[] resultCoeff = new double[numberOfVariables];
            for (int i = 0; i < resultCoeff.Length; i++)
            {
                resultCoeff[i] = 1f;
            }
            resultCoeff = BackSubstitution(matrix, resultCoeff, numberOfVariables);

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

        public static double[][] ConstructMatrix(double[][] data, int numberOfVariables, int numberOfSamples)
        {
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

            return matrix;
        }

        // Eliminating variables below the main diagonal to transform the matrix into an upper triangular form
        public static void ReduceMatrixToRowForm(double[][] matrix, int numberOfVariables)
        {
            for (int i = 0; i < numberOfVariables - 1; i++)
            {
                var varSimplifying = i;
                var firstRow = matrix[i];
                var firstRowValue = firstRow[varSimplifying];

                for (int r = i + 1; r < matrix.Length; r++)
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
        }

        // Calculating the coefficients of the regression model using back substitution
        public static double[] BackSubstitution(double[][] matrix, double[] resultCoeff, int numberOfVariables)
        {
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
            
            return resultCoeff;
        }
    
    }
}
