using Multiple_Regression_Algorithm;
using static Multiple_Regression_Algorithm.Gauss;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Data from Table 1 as Input
        // Data from Table 2 as Output
        [Test]
        public void Test1()
        {
            double[] result = RegressionAlgorithmFromFile("Test_Data_1.txt");

            Assert.That(result[0], Is.EqualTo(0.5665));
            Assert.That(result[1], Is.EqualTo(0.0653));
            Assert.That(result[2], Is.EqualTo(0.0087));
            Assert.That(result[3], Is.EqualTo(0.1510));

            //Assert.Pass();
        }

        // Data from Table 3 as Input
        // Data from Table 4 as Output
        [Test]
        public void Test2()
        {
            double[] result = RegressionAlgorithmFromFile("Test_Data_2.txt");

            Assert.That(result[0], Is.EqualTo(6.7013));
            Assert.That(result[1], Is.EqualTo(0.0784));
            Assert.That(result[2], Is.EqualTo(0.015));
            Assert.That(result[3], Is.EqualTo(0.2461));

            //Assert.Pass();
        }
    }
}