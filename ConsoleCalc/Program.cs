using System;
using System.Collections.Generic;
using System.IO;
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

            do
            {
                Console.Clear();
                Console.Write($"T: {cs.T}\nZ: {cs.Z}\nY: {cs.Y}\nX: {cs.X}\nEntry: ");
                input = Console.ReadLine();
                cs = ParseCommand(input, cs);

            } while (input != "quit");
        }
        static CStack ParseCommand(string input, CStack cs)
        {
            string[] inputSplit = input.Split(' ');
            switch (inputSplit[0])
            {
                case "enter":
                    cs.entry = inputSplit[1];
                    cs.Enter();
                    return cs;
                case "+":
                    cs.BinOp("+");
                    Console.WriteLine("+");
                    return cs;
                case "-":
                    cs.BinOp("−");
                    Console.WriteLine("-");
                    return cs;
                case "*":
                    cs.BinOp("×");
                    Console.WriteLine("*");
                    return cs;
                case "/":
                    cs.BinOp("÷");
                    Console.WriteLine("/");
                    return cs;
                case "show":
                    Console.WriteLine("show");
                    return cs;
                case "parse":
                    try
                    {
                        using (StreamReader sr = new StreamReader(inputSplit[1]))
                        {
                            string fileInput;
                            while ((fileInput = sr.ReadLine()) != null)
                            {
                                cs = ParseCommand(fileInput, cs);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read:");
                    }
                    
                    return cs;
                case "quit":
                    Console.WriteLine("Quitting...");
                    Console.ReadKey();
                    return cs;
                default:
                    Console.WriteLine("Unknown command!");
                    Console.ReadKey();
                    return cs;
            }
        }
    }
}
