using System.Collections.Generic;


namespace Flyweight
{
    enum ChessColor
    {
        Black,
        Write
    }
    class ChessMgr
    {
        private Dictionary<ChessColor, Chess> chesspool = new Dictionary<ChessColor, Chess>();//享元池
        private ChessMgr() { }
        private static ChessMgr inst = null;
        public static ChessMgr Inst
        {
            get
            {
                if (inst == null)
                    inst = new ChessMgr();
                return inst;
            }
        }
        public Chess GetChess(ChessColor color)
        {
            switch(color)
            {
                case ChessColor.Black:
                    if (!chesspool.ContainsKey(ChessColor.Black))
                        chesspool.Add(ChessColor.Black, new BlackChess());
                    return chesspool[ChessColor.Black];
                case ChessColor.Write:
                    if (!chesspool.ContainsKey(ChessColor.Write))
                        chesspool.Add(ChessColor.Write, new WriteChess());
                    return chesspool[ChessColor.Write];
                default:
                    return null;
            }
        }
    }
}
