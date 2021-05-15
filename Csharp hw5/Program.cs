using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw5
{
    class Program
    {
        static int EnterColor()
        {
            int write;
            while (true)
            {
                Console.WriteLine("Enter number of color(Press enter):" +
                    "\n1.White" +
                    "\n2.Black" +
                    "\n3.Yellow" + "\t10.DarkYellow" +
                    "\n4.Red" + "\t\t11.DarkRed" +
                    "\n5.Green" + "\t\t12.DarkGreen" +
                    "\n6.Blue" + "\t\t13.DarkBlue" +
                    "\n7.Cyan" + "\t\t14.DarkCyan" +
                    "\n8.Gray" + "\t\t15.DarkGray" +
                    "\n9.Magenta" + "\t16.DarkMagenta");
                write = Int32.Parse(Console.ReadLine());
                if ((1 <= write && write <= 9) || (11 <= write && write <= 17)) { break; }
                Console.Clear();
            }
            return write;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            GeneralizedFigure figure = new GeneralizedFigure();
            ConsoleKey consoleKey = 0;
            do
            {
                Console.WriteLine("Enter number:" +
                    "\n0.Show figures" +
                    "\n1.Rectangle" +
                    "\n2.Triangle" +
                    "\n3.Rhombus" +
                    "\n4.Trapzoid" +
                    "\n5.Polygon");
                consoleKey = Console.ReadKey().Key;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(" ");
                switch (consoleKey.ToString()[consoleKey.ToString().Length - 1])
                {
                    case '0':
                        Console.Clear();
                        foreach (Figure item in figure)
                        {
                            item.Draw();
                        }
                        break;
                    case '1':
                        Console.Clear();
                        figure.Add(new Rectangle(EnterColor()));
                        Console.WriteLine("Rectangle has added!");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        figure.Add(new Triangle(EnterColor()));
                        Console.WriteLine("Triangle has added!");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        figure.Add(new Rhombus(EnterColor()));
                        Console.WriteLine("Rhombus has added!");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    case '4':
                        Console.Clear();
                        figure.Add(new Trapzoid(EnterColor()));
                        Console.WriteLine("Trapzoid has added!");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    case '5':
                        Console.Clear();
                        figure.Add(new Polygon(EnterColor()));
                        Console.WriteLine("Polygon has added!");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    default:
                        Console.SetCursorPosition(0, 0);
                        continue;
                }
            } while (consoleKey != ConsoleKey.NumPad0 && consoleKey != ConsoleKey.D0);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
