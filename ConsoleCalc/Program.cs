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
            cs.X = 12;
            string input;
            string[] inputSplit;

            do 
            {
                Console.Clear();
                Console.WriteLine(cs.StackString());
                input = Console.ReadLine();
                //Console.WriteLine(input);
                inputSplit = input.Split();
                switch (inputSplit[0])
                {
                    case "enter":
                        Console.WriteLine("enter");
                        break;
                    case "+":
                        Console.WriteLine("+");
                        break;
                    case "-":
                        Console.WriteLine("-");
                        break;
                    case "*":
                        Console.WriteLine("*");
                        break;
                    case "/":
                        Console.WriteLine("/");
                        break;
                    case "show":
                        Console.WriteLine("show");
                        break;
                    default:
                        Console.WriteLine("Unknown command!");
                        break;
                }
            }while (input != "quit");
        }
    }
}
