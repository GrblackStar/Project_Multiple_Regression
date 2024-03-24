using Multiple_Regression_Algorithm;

namespace Tests
{
    public class InputDataTests
    {
        #region Variable Input

        [Test]
        public void ValidVariableInput()
        {
            int result = InputHandler.ValidateVariableInput("5");
            Assert.That(result, Is.EqualTo(5));
        }


        [Test]
        public void InvalidVariableInputLessThanTwo()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var result = InputHandler.ValidateVariableInput("1");

            string expectedErrorMessage = "Invalid input. Please enter a number equal or greater than 2.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(-1));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void InvalidVariableInputNotAnInt()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var result = InputHandler.ValidateVariableInput("5f");

            string expectedErrorMessage = "Invalid input. Please enter a whole number.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(-1));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        #endregion


        #region File Path Input

        [Test]
        public void ValidFilePathInput()
        {
            string? result = InputHandler.ValidateFilePathInput("Test_Data_1.txt");
            Assert.That(result, Is.EqualTo("Test_Data_1.txt"));
        }

        [Test]
        public void InValidFilePathInputNotExistant()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string? result = InputHandler.ValidateFilePathInput("non_existant_file.txt");

            string expectedErrorMessage = "File does not exist. Please enter a valid file path.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void InValidFilePathInputNoExtension()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string? result = InputHandler.ValidateFilePathInput("test_file");

            string expectedErrorMessage = "Invalid or missing file format. Only .txt files are supported.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        [Test]
        public void InValidFilePathInputIncorrectExtension()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string? result = InputHandler.ValidateFilePathInput("test_file.something");

            string expectedErrorMessage = "Invalid or missing file format. Only .txt files are supported.";
            string consoleOutput = stringWriter.ToString();
            Assert.That(result, Is.EqualTo(null));
            Assert.IsTrue(consoleOutput.Contains(expectedErrorMessage));
        }

        #endregion

    }
}
