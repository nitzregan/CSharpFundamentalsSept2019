using System;
using _06_CalculatorRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_CalculatorRepostitoryTests
{
    [TestClass]
    public class CalculatorRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.AddTwoNumbers(5, 5);
            int expected = 10;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.SubtractTwoNumbers(4, 2);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.MultiplyTwoNumbers(4, 2);
            int expected = 8;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.DivideTwoNumbers(4, 2);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.RemainderOfTwoNumbers(4, 2);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
