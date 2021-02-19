using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{//备忘录模式：在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样可以在以后将对象恢复到原先保存的状态。
    class Program
    {
        static MementoMgr mgr = new MementoMgr();
        static int index = -1;
        static void Main(string[] args)
        {
            ChessItem chess = new ChessItem("马", 1, 0);
            chess.Display();
            mgr.AddMemento(chess.Save());
            index++;

            chess.UpdatePos(2, 2);
            chess.Display();
            mgr.AddMemento(chess.Save());
            index++;

            chess.UpdatePos(3, 4);
            chess.Display();
            mgr.AddMemento(chess.Save());
            index++;

            chess.UpdatePos(4, 6);
            chess.Display();
            mgr.AddMemento(chess.Save());
            index++;

            chess.UpdatePos(5, 8);
            chess.Display();
            Console.WriteLine("Undo");
            while (index>=0)
            {
                Undo(chess);
            }
            Console.WriteLine("Redo");
            Redo(chess);
            Console.ReadKey();
        }
        private static void Undo(ChessItem chess)
        {
            chess.Restore(mgr.GetMemento(index--));
            chess.Display();
        }
        private static void Redo(ChessItem chess)
        {
            chess.Restore(mgr.GetMemento(++index));
            chess.Display();
        }
        private void UpdateChess(ChessItem chess, int x,int y)
        {
            chess.X = x;
            chess.Y = y;
        }
    }
}
