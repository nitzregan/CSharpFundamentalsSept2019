using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            //if else if else
            int age = 14;

            if(age >= 21)
            {
                Console.WriteLine("You can drink");
            }
            else if(age < 21)
            {
                Console.WriteLine("Sorry");
                age += 4;
            }
            else
            {
                Console.WriteLine("This is default.");
            }

            if(age == 14)
            {
                Console.WriteLine("You wrote me out. YAY");
            }

            decimal bankAccount = 10m;

            if(bankAccount < 5)
            {
                Console.WriteLine("You need more money.");
            }
            else if(bankAccount >= 5 && bankAccount < 100)
            {
                Console.WriteLine("Moving up in the world");
            }
            else if(bankAccount == 100 || bankAccount == 4)
            {
                Console.WriteLine("Whoa");
            }
            else
            {
                Console.WriteLine("Cool.");
            }
            
            
            // && == AND || == OR < > <= >= != IS NOT

         }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 23;
            switch(age)
            {
                case 1:
                // the code we want to execute           
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Happy Birthday");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Too bad, it will be soon.");
                    break;
            }

        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            //1 condition 2 if true 3 if false
            //1   //2   //3
            // () ? true : false;

            bool isAdult = age > 18 ? true : false;

        }
    }

}
