using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw5
{
    abstract class Figure
    {
        protected int color;
        public abstract void Draw();
        public void SetColor()
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 16:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
            }
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(int _color)
        {
            color = _color;
        }
        public override void Draw()
        {
            base.SetColor();
            Console.WriteLine(
                $"*************" + '\n' +
                $"*           *" + '\n' +
                $"*           *" + '\n' +
                $"*************");
        }
    }
    class Triangle : Figure
    {
        public Triangle(int _color)
        {
            color = _color;
        }
        public override void Draw()
        {
            base.SetColor();
            Console.WriteLine(
                $"       *" + '\n' +
                $"      * *" + '\n' +
                $"     *   *" + '\n' +
                $"    *     *" + '\n' +
                $"   *       *" + '\n' +
                $"  *         *" + '\n' +
                $" *           *" + '\n' +
                $"***************");
        }
    }
    class Rhombus : Figure
    {
        public Rhombus(int _color)
        {
            color = _color;
        }
        public override void Draw()
        {
            base.SetColor();
            Console.WriteLine(
                $"      *" + '\n' +
                $"     * *" + '\n' +
                $"    *   *" + '\n' +
                $"   *     *" + '\n' +
                $"  *       *" + '\n' +
                $" *         *" + '\n' +
                $"*           *" + '\n' +
                $" *         *" + '\n' +
                $"  *       *" + '\n' +
                $"   *     *" + '\n' +
                $"    *   *" + '\n' +
                $"     * *" + '\n' +
                $"      *");
            
        }
    }
    class Trapzoid : Figure
    {
        public Trapzoid(int _color)
        {
            color = _color;
        }
        public override void Draw()
        {
            base.SetColor();
            Console.WriteLine(
                $"*************" + '\n' +
                $"*            *" + '\n' +
                $"*             *" + '\n' +
                $"*              *" + '\n' +
                $"*               *" + '\n' +
                $"*                *" + '\n' +
                $"*                 *" + '\n' +
                $"********************");
        }
    }
    class Polygon : Figure
    {
        public Polygon(int _color)
        {
            color = _color;
        }
        public override void Draw()
        {
            base.SetColor();
            Console.WriteLine(
                $"   *************" + '\n' +
                $"  *             *" + '\n' +
                $" *               *" + '\n' +
                $"*                 *" + '\n' +
                $" *               *" + '\n' +
                $"  *             *" + '\n' +
                $"   *           *" + '\n' +
                $"    ***********");
        }
    }
}
