using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            int number = 1234;
            bool on = true;
            bool off = true;

            decimal hello = 1224334.00m;
            float anotherDecimal = 123.4f;
            double anoternotherDecimal = 1232.341d;

            //int, double, decimal, long, short, float
            byte byteExample = 255; //0-25
            sbyte sByteMax = -128;
            short shortExample = 3267;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            long longExample = 9223372036854775807;

        }






        [TestMethod]
        public void Operators()
        {
            //+ - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            int subtraction = numberTwo - numberOne;
            int division = numberTwo / numberOne;
            int multiplication = numberTwo * numberOne;
            int remainder = numberTwo % numberOne;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(division);
            Console.WriteLine(multiplication);
            Console.WriteLine(remainder);
        }

        [TestMethod]
        public void ReferenceType()
        {
            string firstName = "Nitz";
            string lastName = "Regan";

            //Concatnation
            string concatnation = firstName + " " + lastName;
            Console.WriteLine(concatnation);

            //Composite Formatting
            string composite = string.Format("Hello my name is {0} {1}", firstName, lastName);
            Console.WriteLine(composite);

            //String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            //Classes

            //Structs

            //Collections

            List<string> myList = new List<string>();
            myList.Add("Hello World!");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello World!");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Stack<int> newStack = new Stack<int>();

            string banana = "Fruit";
            string[] stringArray = { "Hello", "Character", "Food", "Water" };


        }
    }
}
