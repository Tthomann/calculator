using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Calculate : IOperations
    {
        public double currentNumber;
        private double inputNumber;
        
        public Calculate()
        {

        }
        public double firstInput()
        {
            currentNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("current number is now " + currentNumber);
            return currentNumber;
        }

        double IOperations.addition()
        {
            Console.WriteLine("the current number is " + currentNumber);
            Console.WriteLine("");
            Console.WriteLine("input the number to add with");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            currentNumber = currentNumber += inputNumber;
            Console.WriteLine("the new number is " + currentNumber);
            return currentNumber;
        }
        double IOperations.subtraction()
        {
            Console.WriteLine("the current number is " + currentNumber);
            Console.WriteLine("");
            Console.WriteLine("input the number you'd like to subtract with");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            currentNumber = currentNumber -= inputNumber;
            Console.WriteLine("the new number is " + currentNumber);
            return currentNumber;

        }
        double IOperations.multiplication()
        {
            Console.WriteLine("the current number is " + currentNumber);
            Console.WriteLine("");
            Console.WriteLine("input the number you'd like to multiply with");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            currentNumber = currentNumber * inputNumber;
            Console.WriteLine("the new number is " + currentNumber);
            return currentNumber;
        }

        double IOperations.division()
        {
            Console.WriteLine("the current number is " + currentNumber);
            Console.WriteLine("");
            Console.WriteLine("input the number you'd like to divide with");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            currentNumber = currentNumber / inputNumber;
            Console.WriteLine("the new number is " + currentNumber);
            return currentNumber;
        }
        double IOperations.exponential()
        {
            Console.WriteLine("the current number is " + currentNumber);
            Console.WriteLine("");
            Console.WriteLine("enter the exponent to use for this operation");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            currentNumber = Math.Pow(currentNumber, inputNumber);
            Console.WriteLine("the new number is " + currentNumber);
            return currentNumber;
        }
    }
}
