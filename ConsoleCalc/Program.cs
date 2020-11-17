using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStackClass;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack cs;
            cs = new CStack();
            string input;
            string[] inputSplit;

            do
            {
                Console.Clear();
                Console.Write($"T: {cs.T}\nZ: {cs.Z}\nY: {cs.Y}\nX: {cs.X}\nEntry: ");
                input = Console.ReadLine();
                inputSplit = input.Split(' ');
                switch (inputSplit[0])
                {
                    case "enter":
                        cs.entry = inputSplit[1];
                        cs.Enter();
                        break;
                    case "+":
                        cs.BinOp("+");
                        Console.WriteLine("+");
                        break;
                    case "-":
                        cs.BinOp("−");
                        Console.WriteLine("-");
                        break;
                    case "*":
                        cs.BinOp("×");
                        Console.WriteLine("*");
                        break;
                    case "/":
                        cs.BinOp("÷");
                        Console.WriteLine("/");
                        break;
                    case "show":
                        Console.WriteLine("show");
                        break;
                    default:
                        Console.WriteLine("Unknown command!");
                        break;
                }
            } while (input != "quit");
        }
    }
}
