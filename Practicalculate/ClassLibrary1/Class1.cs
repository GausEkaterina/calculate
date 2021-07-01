using NUnit.Framework;
using static Practicalculate.Form1;

namespace ClassLibrary1
{
    public class PLUSTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 6, 9)]
        [TestCase(-5, -3, -8)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new PLUS();
            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
    public class MinusTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 4, 1)]
        [TestCase(-6, -2, -4)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MINUS();
            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
    public class DIVITIONTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 3, 1)]
        [TestCase(-8, -4, 2)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new DIVITION();
            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
    public class MULTYTests
    {
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(-2, -6)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MULTIPLY();
            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
    public class MODULTests
    {
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(-6, 6)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MODULE();
            //ACT
            double actualResult = calc.Calculate(firstValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
    public class LOGTests
    {
        [TestCase(0, 0)]
        [TestCase(10, 2.302585092994)]
        [TestCase(-4, 1.3862943611199 + 3.1415926535898)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new LOG();
            //ACT
            double actualResult = calc.Calculate(firstValue);
            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
}
