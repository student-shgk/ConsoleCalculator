using System;

namespace ConsoleCalculator
{
    class Program
    {
        static int operand1;

        static int operand2; //коммент

        static string operation;

        static void Main(string[] args)
        {
            Program.Read();
            Program.Write(Program.applyOperation().ToString());
        }

        static void Read()
        {
            string[] input = new string[3];
            input = Console.ReadLine().Split(' ');
            Program.operand1 = Int32.Parse(input[0]);
            Program.operation = input[1];
            Program.operand2 = Int32.Parse(input[2]);
        }

        static void Write(string result)
        {
            Console.WriteLine(result);
        }

        static int Sub()
        {
            return Program.operand1 - Program.operand2;
        }
	
	static int Sum()
        {
            return Program.operand1 + Program.operand2;
        }
        static int applyOperation()
        {
            switch (Program.operation)
            {
                case "+":
                    return Program.Sum();

                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
