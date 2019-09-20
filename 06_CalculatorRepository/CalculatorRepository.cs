using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepository
{
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }

        public int RemainderOfTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne % numberTwo;
            return result;
        }
    }
}
