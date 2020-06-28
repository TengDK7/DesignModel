using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Location
    {
        int x;
        int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Location(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    abstract class Chess
    {
        public abstract string Color { get; }
        public abstract void Display(Location location);
    }
    class BlackChess : Chess
    {
        public override string Color => "黑色";

        public override void Display(Location location)
        {
            Console.WriteLine($"位置（{location.X},{location.Y}）的{Color}棋子");
        }
    }
    class WriteChess : Chess
    {
        public override string Color => "白色";

        public override void Display(Location location)
        {
            Console.WriteLine($"位置（{location.X},{location.Y}）的{Color}棋子");
        }
    }
}
