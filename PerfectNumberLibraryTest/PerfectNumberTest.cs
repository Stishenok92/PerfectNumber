using System.ComponentModel.DataAnnotations;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PerfectNumberLibrary.PerfectNumber;

namespace PerfectNumberLibraryTest
{
    [TestClass]
    public class PerfectNumberTest
    {
        [TestMethod]
        public void ValidationNaturalNumber_12_ReturnedTrue()
        {
            //arrange
            int number = 12;
            bool expected = true;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationNaturalNumber_Minus43_ReturnedFalse()
        {
            //arrange
            int number = -43;
            bool expected = false;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSumDivisors_16_Returned15()
        {
            //arrange
            int number = 16;
            int expected = 15;

            //act
            int actual = CalculateSumDivisors(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSumDivisors_1_Returned0()
        {
            //arrange
            int number = 1;
            int expected = 0;

            //act
            int actual = CalculateSumDivisors(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPerfectNumber_28_ReturnedTrue()
        {
            //arrange
            int number = 28;
            bool expected = true;

            //act
            bool actual = IsPerfectNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPerfectNumber_32_ReturnedFalse()
        {
            //arrange
            int number = 32;
            bool expected = false;

            //act
            bool actual = IsPerfectNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void IsPerfectNumber_32_ValidationException()
        {
            //arrange
            int number = -2;

            //act + assert
            IsPerfectNumber(number);
        }
    }
}