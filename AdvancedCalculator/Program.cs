using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            CalculatorScreen calculatorScreen = new CalculatorScreen();
            IOperations implementOperations = (IOperations)calculate;
            IView interfaceView = (IView)calculatorScreen;
            int choiceInput;
            bool doneComputing = false;
            Console.WriteLine("press 1 to start with a number you'd like to perform operations on");
            calculate.firstInput();
            interfaceView.menu();
            while (doneComputing != true)
            {
                    
                choiceInput = Convert.ToInt32(Console.ReadLine());


                switch (choiceInput)
                {

                    case 1:
                        implementOperations.addition();
                        interfaceView.smallMenu();
                        break;
                    case 2:
                        implementOperations.subtraction();
                        interfaceView.smallMenu();
                        break;
                    case 3:
                        implementOperations.multiplication();
                        interfaceView.smallMenu();
                        break;
                    case 4:
                        implementOperations.division();
                        interfaceView.smallMenu();
                        break;
                    case 5:
                        implementOperations.exponential();
                        interfaceView.smallMenu();
                        break;
                    case 0:
                        Console.WriteLine("goodbye!");
                        doneComputing = true;
                        break;
                }
                   
            }
                
            
        }
    }
}
