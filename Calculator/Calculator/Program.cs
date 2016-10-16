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
            string UserInput;
            double Sum;
            double FirstNumber;
            double SecondNumber;
            bool ProgramWorking = true;

            Console.WriteLine("Basic Calculator");
            while (ProgramWorking)
            {
                
                Console.WriteLine("Enter calculation");
                UserInput = Console.ReadLine();

                if (UserInput.Contains('+'))
                {
                    Sum = (UserInput[0] + UserInput[2]) - 96;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 2));
                }
                else if (UserInput.Contains('-'))
                {
                    Sum = UserInput[0] - UserInput[2];
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 2));
                }
                else if (UserInput.Contains('*'))
                {
                    FirstNumber = UserInput[0] - 48;
                    SecondNumber = UserInput[2] - 48;
                    Sum = FirstNumber * SecondNumber;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 2));
                }
                else if (UserInput.Contains('/'))
                {
                    FirstNumber = UserInput[0] - 48;
                    SecondNumber = UserInput[2] - 48;
                    Sum = FirstNumber / SecondNumber;
                    Console.WriteLine("{0} = {1}", UserInput, Math.Round(Sum, 2));
                }

            }
            
        }
    }
}
