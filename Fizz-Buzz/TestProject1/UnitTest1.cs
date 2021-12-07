using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizz_Buzz;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzz_WhenNumeroDivisibleSoloX3_ThenRetornarFizz()
        {
                //Arrange
                int numero = 3;
                string expected = "fizz";
                string actual;
                //Act
                actual = numero.FizzBuzz();
                //Assert
                Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void FizzBuzz_WhenNumeroDivisibleSoloX5_ThenRetornarFizz()
        {
            //Arrange
            int numero = 10;
            string expected = "buzz";
            string actual;
            //Act
            actual = numero.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_WhenNumeroDivisibleX3YX5_ThenRetornarFizz()
        {
            //Arrange
            int numero = 15;
            string expected = "fizz buzz";
            string actual;
            //Act
            actual = numero.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_WhenNumeroNoDivisibleX3YX5_ThenRetornarFizz()
        {
            //Arrange
            int numero = 8;
            string expected = "8";  //numero.ToString();
            string actual;
            //Act
            actual = numero.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
