using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnaasN
            string UserInput;
            double Sum;
            double FirstNumber;
            double SecondNumber;
            bool ProgramWorking = true;
            int AsciiConvert = 48;
            int PositionOfOperator;

            Console.WriteLine("Basic Calculator");
            while (ProgramWorking)
            {

                Console.WriteLine("Enter calculation");
                UserInput = Console.ReadLine();
                if (UserInput.Contains('+'))
                {
                    PositionOfOperator = UserInput.IndexOf('+');
                    FirstNumber = UserInput[0] - AsciiConvert;
                    SecondNumber = UserInput[2] - AsciiConvert;                                                                                                              
                    Sum = FirstNumber + SecondNumber;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 3));
                }
                else if (UserInput.Contains('-'))
                {
                    Sum = UserInput[0] - UserInput[2];
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 3));
                }
                else if (UserInput.Contains('*'))
                {
                    FirstNumber = UserInput[0] - AsciiConvert;
                    SecondNumber = UserInput[2] - AsciiConvert;
                    Sum = FirstNumber * SecondNumber;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 3));
                }
                else if (UserInput.Contains('/'))
                {
                    FirstNumber = UserInput[0] - AsciiConvert;
                    SecondNumber = UserInput[2] - AsciiConvert;
                    Sum = FirstNumber / SecondNumber;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 3));
                }
                else Console.WriteLine("Correct operator was not entered, Retry with correct operator (e.i. '+', '-', '/' or '*'.");

            }
            
        }
    }
}
