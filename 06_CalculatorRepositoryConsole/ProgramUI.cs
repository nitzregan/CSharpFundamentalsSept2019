using _06_CalculatorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepositoryConsole
{
    class ProgramUI
    {
        public void GetTwoNumbersFromUserAndPrintResultToUser()
        {
            Console.WriteLine("Please enter a number.");
            string firstUserInput = Console.ReadLine();
            int numberOne = int.Parse(firstUserInput);

            Console.WriteLine("Please enter another number.");
            string secondUserInput = Console.ReadLine();
            int numberTwo = int.Parse(secondUserInput);

            CalculatorRepository calcRepo = new CalculatorRepository();
            int result = calcRepo.AddTwoNumbers(numberOne, numberTwo);

            Console.WriteLine($"Your result is:  {result}");

            Console.ReadKey();
        }



    }
}


