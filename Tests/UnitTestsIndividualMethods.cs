﻿using Multiple_Regression_Algorithm;

namespace Tests
{
    public class UnitTestsIndividualMethods
    {

        #region ReadDataFromFile
        [Test]
        public void ReadDataFromFileTestfile1()
        {
            double[][] expectedData =
            {
                new double[] { 345, 65, 23, 31.4 },
                new double[] { 168, 18, 18, 14.6 },
                new double[] { 94, 0, 0, 6.4 },
                new double[] { 187, 185, 98, 28.3 },
                new double[] { 621, 87, 10, 42.1 },
                new double[] { 255, 0, 0, 15.3 }
            };

            double[][]? actualData = MultipleRegression.ReadDataFromFile("Test_Data_1.txt");

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
            Assert.That(actualData[4], Is.EqualTo(expectedData[4]));
            Assert.That(actualData[5], Is.EqualTo(expectedData[5]));
        }

        [Test]
        public void ReadDataFromFileTestfile2()
        {
            double[][] expectedData =
            {
                new double[] { 1142, 1060, 325, 201 },
                new double[] { 863, 995, 98, 98 },
                new double[] { 1065, 3205, 23, 162 },
                new double[] { 554, 120, 0, 54 },
                new double[] { 983, 2896, 120, 138 },
                new double[] { 256, 485, 88, 61 }
            };

            double[][]? actualData = MultipleRegression.ReadDataFromFile("Test_Data_2.txt");

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
            Assert.That(actualData[4], Is.EqualTo(expectedData[4]));
            Assert.That(actualData[5], Is.EqualTo(expectedData[5]));
        }

        [Test]
        public void ReadDataFromFileTestfile3()
        {
            double[][] expectedData =
            {
                new double[] { 1, 0, 4, 2 },
                new double[] { 1, 2, 6, 2 },
                new double[] { 2, 0, 8, 8 },
                new double[] { 2, 1, 9, 4 },
                new double[] { 1, 0, 10, 5 },
                new double[] { 1, 0, 10, 5 }
            };

            double[][]? actualData = MultipleRegression.ReadDataFromFile("Test_Data_3.txt");

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
            Assert.That(actualData[4], Is.EqualTo(expectedData[4]));
            Assert.That(actualData[5], Is.EqualTo(expectedData[5]));
        }

        #endregion


        #region ConstructMatrix

        [Test]
        public void ConstructMatrixTestfile1()
        {
            double[][] expectedData =
            {
                new double[] { 6, 1670, 355, 149, 138.10000000000002 },
                new double[] { 1670, 641720, 114071, 35495, 49225.100000000006 },
                new double[] { 355, 114071, 46343, 20819, 11202 },
                new double[] { 149, 35495, 20819, 10557, 4179.4 }
            };

            double[][] inputData =
            {
                new double[] { 345, 65, 23, 31.4 },
                new double[] { 168, 18, 18, 14.6 },
                new double[] { 94, 0, 0, 6.4 },
                new double[] { 187, 185, 98, 28.3 },
                new double[] { 621, 87, 10, 42.1 },
                new double[] { 255, 0, 0, 15.3 }
            };

            double[][]? actualData = MultipleRegression.ConstructMatrix(inputData, 4, 6);

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void ConstructMatrixTestfile2()
        {
            double[][] expectedData =
            {
                new double[] { 6, 4863, 8761, 654, 714 },
                new double[] { 4863, 4521899, 8519938, 620707, 667832},
                new double[] { 8761, 8519938, 21022091, 905925, 1265493 },
                new double[] { 654, 620707, 905925, 137902, 100583 }
            };

            double[][] inputData =
            {
                new double[] { 1142, 1060, 325, 201 },
                new double[] { 863, 995, 98, 98 },
                new double[] { 1065, 3205, 23, 162 },
                new double[] { 554, 120, 0, 54 },
                new double[] { 983, 2896, 120, 138 },
                new double[] { 256, 485, 88, 61 }
            };

            double[][]? actualData = MultipleRegression.ConstructMatrix(inputData, 4, 6);

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void ConstructMatrixTestfile3()
        {
            double[][] expectedData =
           {
                new double[] { 6, 8, 3, 47, 26 },
                new double[] { 8, 12, 4, 64, 38 },
                new double[] { 3, 4, 5, 21, 8 },
                new double[] { 47, 64, 21, 397, 220 }
            };

            double[][] inputData =
            {
                new double[] { 1, 0, 4, 2 },
                new double[] { 1, 2, 6, 2 },
                new double[] { 2, 0, 8, 8 },
                new double[] { 2, 1, 9, 4 },
                new double[] { 1, 0, 10, 5 },
                new double[] { 1, 0, 10, 5 }
            };

            double[][]? actualData = MultipleRegression.ConstructMatrix(inputData, 4, 6);

            Assert.That(actualData, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        #endregion


        #region ReduceMatrixToRowForm

        [Test]
        public void ReduceMatrixToRowFormTestfile1()
        {
            double[][] matrix =
            {
                new double[] { 6, 1670, 355, 149, 138.10000000000002 },
                new double[] { 1670, 641720, 114071, 35495, 49225.100000000006 },
                new double[] { 355, 114071, 46343, 20819, 11202 },
                new double[] { 149, 35495, 20819, 10557, 4179.4 }
            };

            double[][] expectedData =
            {
                new double[] { 6, 1670, 355, 149, 138.10000000000002 },
                new double[] { 0, 176903.33333333337, 15262.666666666672, - 5976.666666666664, 10787.26666666667 },
                new double[] { 0, 0, 24022.018158693074, 12518.814785852916, 2100.391682274687 },
                new double[] { 0, 0, 0, 130.86722946170175, 19.76731802670497 },
            };

            MultipleRegression.ReduceMatrixToRowForm(matrix, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(matrix[0], Is.EqualTo(expectedData[0]));
            Assert.That(matrix[1], Is.EqualTo(expectedData[1]));
            Assert.That(matrix[2], Is.EqualTo(expectedData[2]));
            Assert.That(matrix[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void ReduceMatrixToRowFormTestfile2()
        {
            double[][] matrix =
            {
                new double[] { 6, 4863, 8761, 654, 714 },
                new double[] { 4863, 4521899, 8519938, 620707, 667832 },
                new double[] { 8761, 8519938, 21022091, 905925, 1265493 },
                new double[] { 654, 620707, 905925, 137902, 100583 }
            };

            double[][] expectedData =
            {
                new double[] { 6, 4863, 8761, 654, 714 },
                new double[] { 0, 580437.5, 1419147.5, 90640, 89135 },
                new double[] { 0, 0, 4759809.443422704, - 270635.3352428125, 5002.332227845356 },
                new double[] { 0, 0, 0, 37073.92977685743, 9122.275195227476 },
            };

            MultipleRegression.ReduceMatrixToRowForm(matrix, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(matrix[0], Is.EqualTo(expectedData[0]));
            Assert.That(matrix[1], Is.EqualTo(expectedData[1]));
            Assert.That(matrix[2], Is.EqualTo(expectedData[2]));
            Assert.That(matrix[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void ReduceMatrixToRowFormTestfile3()
        {
            double[][] matrix =
            {
                new double[] { 6, 8, 3, 47, 26 },
                new double[] { 8, 12, 4, 64, 38 },
                new double[] { 3, 4, 5, 21, 8 },
                new double[] { 47, 64, 21, 397, 220 }
            };

            double[][] expectedData =
            {
                new double[] { 6, 8, 3, 47, 26 },
                new double[] { 0, 1.333333333333334, 0, 1.3333333333333357, 3.3333333333333357 },
                new double[] { 0, 0, 3.5, - 2.5, - 5 },
                new double[] { 0, 0, 0, 25.71428571428575, 9.428571428571432 },
            };

            MultipleRegression.ReduceMatrixToRowForm(matrix, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(matrix[0], Is.EqualTo(expectedData[0]));
            Assert.That(matrix[1], Is.EqualTo(expectedData[1]));
            Assert.That(matrix[2], Is.EqualTo(expectedData[2]));
            Assert.That(matrix[3], Is.EqualTo(expectedData[3]));
        }

        #endregion


        #region BackSubstitution
        [Test]
        public void BackSubstitutionTsetfile1()
        {
            double[][] matrix =
            {
                new double[] { 6, 1670, 355, 149, 138.10000000000002 },
                new double[] { 0, 176903.33333333337, 15262.666666666672, - 5976.666666666664, 10787.26666666667 },
                new double[] { 0, 0, 24022.018158693074, 12518.814785852916, 2100.391682274687 },
                new double[] { 0, 0, 0, 130.86722946170175, 19.76731802670497 }
            };

            double[] expectedData = { 0.5664574696019447, 0.06532925469423313, 0.008718736194577725, 0.151048647610362 };

            double[] actualData = MultipleRegression.BackSubstitution(matrix, new double[] { 1, 1, 1, 1 }, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void BackSubstitutionTsetfile2()
        {
            double[][] matrix =
            {
                new double[] { 6, 4863, 8761, 654, 714 },
                new double[] { 0, 580437.5, 1419147.5, 90640, 89135 },
                new double[] { 0, 0, 4759809.443422704, - 270635.3352428125, 5002.332227845356 },
                new double[] { 0, 0, 0, 37073.92977685743, 9122.275195227476 }
            };

            double[] expectedData = { 6.701336536389111, 0.07836603673386544, 0.015041331199344947, 0.24605633258014775 };

            double[] actualData = MultipleRegression.BackSubstitution(matrix, new double[] { 1, 1, 1, 1 }, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        [Test]
        public void BackSubstitutionTsetfile3()
        {
            double[][] matrix =
            {
                new double[] { 6, 8, 3, 47, 26 },
                new double[] { 0, 1.333333333333334, 0, 1.3333333333333357, 3.3333333333333357 },
                new double[] { 0, 0, 3.5, - 2.5, - 5 },
                new double[] { 0, 0, 0, 25.71428571428575, 9.428571428571432 }
            };

            double[] expectedData = { -0.7999999999999977, 2.1333333333333337, -1.1666666666666667, 0.3666666666666663 };

            double[] actualData = MultipleRegression.BackSubstitution(matrix, new double[] { 1, 1, 1, 1 }, 4);

            Assert.That(matrix, Has.Length.EqualTo(expectedData.Length));
            Assert.That(actualData[0], Is.EqualTo(expectedData[0]));
            Assert.That(actualData[1], Is.EqualTo(expectedData[1]));
            Assert.That(actualData[2], Is.EqualTo(expectedData[2]));
            Assert.That(actualData[3], Is.EqualTo(expectedData[3]));
        }

        #endregion
    }
}
