using Multiple_Regression_Algorithm;

namespace Tests
{
    public class DataHandlingTests
    {

        [Test]
        public void DataInvalidSampleNumber()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_5.txt");

            string expectedErrorMessage = "Invalid number of samples. Ensure that the samples are more than the variables.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void DataInconsistantDataFormat()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_6.txt");

            string expectedErrorMessage = "Inconsistent data format. Ensure that the samples are only numbers.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void DataMulticolinearity()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_4.txt");

            string expectedErrorMessage = "The data has multicolinearity. A correlation coefficient is close to 1 or -1";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void DataSamplesValueZero()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_9.txt");

            string expectedErrorMessage = "One or more variables have only zero sample values. Exiting program.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void DataVariablesWithTheSameSamples()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_10.txt");

            string expectedErrorMessage = "Two or more variables have the same values for every sample.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

    }
}
