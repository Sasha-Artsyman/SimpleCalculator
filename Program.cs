/*
First input => number
Second input => number
Third input => operation (+ or - or / or *)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Operation (+ or - or / or *): ");
            char c = Convert.ToChar(Console.ReadLine());
            double res;
            if (c == '+')
            {
                res = a + b;
                Console.WriteLine(a + " + " + b + " = " + res);
            }
            else if (c == '-')
            {
                res = a - b;
                Console.WriteLine(a + " - " + b + " = " + res);
            }
            else if (c == '*')
            {
                res = a * b;
                Console.WriteLine(a + " * " + b + " = " + res);
            }
            else if (c == '/')
            {
                if (b != 0)
                {
                    res = a / b;
                    Console.WriteLine(a + " / " + b + " = " + res);
                }
                else
                {
                    Console.WriteLine("Can't divide by 0");
                }
            }
            else
            {
                Console.WriteLine("You must write \n\n1. number\n2. number \n3. +, -, / or *");
            }
            Console.ReadLine();
        }
    }
}