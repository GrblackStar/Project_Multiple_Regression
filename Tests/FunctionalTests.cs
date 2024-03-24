using Multiple_Regression_Algorithm;

namespace Tests
{
    public class FunctionalTests
    {
        #region File 1
        // Data from Table 1 as Input
        // Data from Table 2 as Output
        [Test]
        public void RegressionAlgorithmFromFileTestfile1()
        {
            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_1.txt");

            Assert.That(result?[0], Is.EqualTo(0.5665));
            Assert.That(result[1], Is.EqualTo(0.0653));
            Assert.That(result[2], Is.EqualTo(0.0087));
            Assert.That(result[3], Is.EqualTo(0.1510));
        }

        #endregion

        #region File 2
        // Data from Table 3 as Input
        // Data from Table 4 as Output
        [Test]
        public void RegressionAlgorithmFromFileTestfile2()
        {
            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_2.txt");

            Assert.That(result?[0], Is.EqualTo(6.7013));
            Assert.That(result[1], Is.EqualTo(0.0784));
            Assert.That(result[2], Is.EqualTo(0.015));
            Assert.That(result[3], Is.EqualTo(0.2461));
        }

        #endregion

        #region File 3
        [Test]
        public void RegressionAlgorithmFromFileTestfile3()
        {
            double[]? result = MultipleRegression.RegressionAlgorithmFromFile("Test_Data_3.txt");

            Assert.That(result?[0], Is.EqualTo(-0.8));
            Assert.That(result[1], Is.EqualTo(2.1333));
            Assert.That(result[2], Is.EqualTo(-1.1667));
            Assert.That(result[3], Is.EqualTo(0.3667));
        }

        #endregion

    }
}