using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{//享元模式：运用共享技术有效的支持大量细粒度对象的复用
    class Program
    {
        static void Main(string[] args)
        {
            var chessb = ChessMgr.Inst.GetChess(ChessColor.Black);
            var chessw = ChessMgr.Inst.GetChess(ChessColor.Write);

            var chessb2 = ChessMgr.Inst.GetChess(ChessColor.Black);
            var chessw2 = ChessMgr.Inst.GetChess(ChessColor.Write);

            Console.WriteLine($"两个黑棋相同：{chessb == chessb2}");
            Console.WriteLine($"两个白棋相同：{chessw == chessw2}");


            chessb.Display(new Location(20, 20));
            chessb2.Display(new Location(15, 15));
            chessw.Display(new Location(10, 30));
            chessw2.Display(new Location(0, 0));
            Console.ReadKey();

        }
    }
}
