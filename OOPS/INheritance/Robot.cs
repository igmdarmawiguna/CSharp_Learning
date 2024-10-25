using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{

    class Robot
    {
        private int op1, op2;
        private int operationType( string expression )
        {
            op1 = int.Parse( expression.Substring(0, 1) );
            op2 = int.Parse( expression.Substring(2, 1) );
            int opcode;
            string oper = expression.Substring(1, 1);
            if (oper.Equals("+")) opcode = 1;
            else if (oper.Equals("-")) opcode = 2;
            else if (oper.Equals("*")) opcode = 3;
            else
                opcode = 4;
            return opcode;
        }
        public double Eval(string expression)
        {
            double result = 0;
            switch (operationType(expression))
            {
                case 1:
                    result = op1 + op2; break;
                case 2:
                    result = op1 - op2; break;
                case 3:
                    result = op1 * op2; break;
                case 4:
                    result = (double)op1 / op2;
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression");
            string exp = Console.ReadLine();

            Robot r = new Robot();
            Console.WriteLine(r.Eval(exp));
        }
    }
}
