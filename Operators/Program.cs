using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qn1: Binary opr");
            Console.WriteLine("Enter first number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator symbol");
            char opr = char.Parse(Console.ReadLine());
            float result;
            switch (opr)
            {
                case '+':
                    result = num1+num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
               default:
                    result = 0;
                    break;

            }
            Console.WriteLine("result:"+ result+"\n");

           

            Console.WriteLine("qn2: Unary Opr");
            Console.WriteLine("Enter the number");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"a is {num3} and result for  a++ is "+ num3++);
            Console.WriteLine($"a is {num3} and result for  a-- is " + num3--);
            Console.WriteLine($"a is {num3} and result for  ++a is " + ++num3);
            Console.WriteLine($"a is {num3} and result for  --a is " + --num3);
            Console.WriteLine("****\n");

            Console.WriteLine("qn3: Relational Opr");
            Console.WriteLine("Enter first number");
            float num4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float num5 = float.Parse(Console.ReadLine());

            Console.Write("result for  Equal to Operator is :");
            Console.WriteLine(num4== num5);
            Console.Write("result for  Greater than Operator is  :");

            Console.WriteLine(num4 > num5);


            Console.WriteLine($" result for  Less than Operator is ");
            Console.WriteLine(num4 < num5);


            Console.WriteLine($"result for Greater than or Equal to Operator: is " );
            Console.WriteLine(num4 >= num5);


            Console.WriteLine($"result for Lesser than or Equal to Operator: is " );

            Console.WriteLine(num4 <= num5);


            Console.ReadLine();
        }
    }
}

