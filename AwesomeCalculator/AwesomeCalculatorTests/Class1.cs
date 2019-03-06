using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input9and1_Returns10()
        {

            //Arrange
            double number1 = 9;
            double number2 = 1;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input3and5_Returns8()
        {

            //Arrange
            double number1 = 3;
            double number2 = 5;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input4and6_Returns10()
        {

            //Arrange
            double number1 = 4;
            double number2 = 6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input1and1_Returns0()
        {

            //Arrange
            double number1 = 1;
            double number2 = 1;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input3and2_Returns1()
        {

            //Arrange
            double number1 = 3;
            double number2 = 2;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input5and4_Returns1()
        {

            //Arrange
            double number1 = 5;
            double number2 = 4;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input2and2_Returns4()
        {

            //Arrange
            double number1 = 2;
            double number2 = 2;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input7and2_Returns14()
        {

            //Arrange
            double number1 = 7;
            double number2 = 2;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input6and3_Returns18()
        {

            //Arrange
            double number1 = 6;
            double number2 = 3;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input16and2_Returns8()
        {

            //Arrange
            double number1 = 16;
            double number2 = 2;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input6and3_Returns2()
        {

            //Arrange
            double number1 = 6;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input8and4_Returns2()
        {

            //Arrange
            double number1 = 8;
            double number2 = 4;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input1and3_Returns0point33()
        {

            //Arrange
            double number1 = 1;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input2and1_Returns2()
        {

            //Arrange
            double number1 = 2;
            double number2 = 1;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input9and3_Returns3()
        {

            //Arrange
            double number1 = 9;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
