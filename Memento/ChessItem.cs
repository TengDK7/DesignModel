using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class ChessItem
    {
        private string text;
        private int x;
        private int y;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public ChessItem(string label,int x,int y)
        {
            this.text = label;
            this.x = x;
            this.y = y;
        }
        public void UpdatePos(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"{text}:({x},{y})");
        }
        internal ChessMemento Save()
        {
            return new ChessMemento(text, x, y);
        }
        internal void Restore(ChessMemento memento)
        {
            text = memento.Text;
            x = memento.X;
            y = memento.Y;
        }
    }

    internal class ChessMemento
    {
        private string text;
        private int x;
        private int y;

        internal string Text
        {
            get { return text; }
            set { text = value; }
        }
        internal int X
        {
            get { return x; }
            set { x = value; }
        }
        internal int Y
        {
            get { return y; }
            set { y = value; }
        }
        internal ChessMemento(string label, int x, int y)
        {
            this.text = label;
            this.x = x;
            this.y = y;
        }
    }
}
