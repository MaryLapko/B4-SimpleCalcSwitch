using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double a;
                double b;
                double total;
                char oper;
                Console.WriteLine("Input specific number:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input a specific operator:");

                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Input another number:");
                b = Convert.ToDouble(Console.ReadLine());

                switch (oper)
                {
                    case '+':
                        total = a + b;
                        Console.WriteLine("Summ " + a + " and " + b + " equals " + total + ".");
                        break;

                    case '-':

                        total = a - b;
                        Console.WriteLine("Difference " + a + " and " + b + " equals " + total + ".");
                        break;

                    case '*':

                        total = a * b;
                        Console.WriteLine("Multiplication " + a + " on " + b + " equals " + total + ".");
                        break;

                    case '/':

                        total = a / b;
                        Console.WriteLine("Division " + a + " on " + b + " eqauals " + total + ".");

                        break;

                    default:
                        Console.WriteLine("Unknown operator.");                      
                    
                        Console.WriteLine("Do you want to continue using the calculator? (y/n)");
                        again = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
