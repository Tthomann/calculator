using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class CalculatorScreen : IView
    {
        
        void IView.menu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Welcome to the Advanced Calculator!");
            Console.WriteLine("");
            Console.WriteLine("implemented patterns: Facade, Factory, ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
           
            Console.WriteLine(":operations:");
            Console.WriteLine("(1) addition");
            Console.WriteLine("(2) subtraction");
            Console.WriteLine("(3) multiplication");
            Console.WriteLine("(4) division");
            Console.WriteLine("(5 exponential");
           
                
        }
        void IView.smallMenu()
        {
            Console.WriteLine("");
            Console.WriteLine(":operations:");
            Console.WriteLine("(1) addition");
            Console.WriteLine("(2) subtraction");
            Console.WriteLine("(3) multiplication");
            Console.WriteLine("(4) division");
            Console.WriteLine("(5 exponential");
            Console.WriteLine("");

        }
    }
}
