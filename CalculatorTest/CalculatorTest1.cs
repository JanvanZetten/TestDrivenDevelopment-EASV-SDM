using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void MakeACalculatorInstance()
        {
            var calc = new CalculatorInstance();
            Assert.IsNotNull(calc, "There was not made a calculator intance");
        }

        [TestMethod]
        public void AddTwoNumbers(){
            var calc = new CalculatorInstance();

            var num1 = 5.8;
            var num2 = 3.0;

            var result = num1 + num2;

            Assert.AreEqual(result, calc.Add(num1, num2));

        }

        [TestMethod]
        public void SubstractTwoNumbers(){
            var calc = new CalculatorInstance();

            var num1 = 5.8;
            var num2 = 3.0;

            var result = num1 - num2;

            Assert.AreEqual(result, calc.Substract(num1, num2));
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            var calc = new CalculatorInstance();

            var num1 = 5.8;
            var num2 = 3.0;

            var result = num1 * num2;

            Assert.AreEqual(result, calc.Multiply(num1, num2));
        }

        [TestMethod]
        public void DivideTwoDoubles()
        {
            var calc = new CalculatorInstance();

            var num1 = 5.8;
            var num2 = 3.0;

            var result = num1 / num2;

            Assert.AreEqual(result, calc.Divide(num1, num2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideDoubleByZero()
        {
            var calc = new CalculatorInstance();

            var num1 = 5.8;
            var num2 = 0.0;

            var result = calc.Divide(num1, num2);
            Assert.Fail("Divided by zero! {0}", result);
        }

        [TestMethod]
        public void DivideTwoIntegers()
        {
            var calc = new CalculatorInstance();

            var num1 = 5;
            var num2 = 3;

            var result = num1 / num2;

            Assert.AreEqual(result, calc.Divide(num1, num2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideIntegerByZero()
        {
            var calc = new CalculatorInstance();

            var num1 = 5;
            var num2 = 0;

            var result = calc.Divide(num1, num2);
            Assert.Fail("Divided by zero! {0}", result);
        }

    }
}
