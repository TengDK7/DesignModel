using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class MementoMgr
    {
        private List<ChessMemento> chessstates = new List<ChessMemento>();
        internal ChessMemento GetMemento(int index)
        {
            if (index<0||chessstates == null || chessstates.Count <= index)
                return null;
            return chessstates[index];
        }
        internal void AddMemento(ChessMemento memento)
        {
            if (memento == null)
                return;
            chessstates.Add(memento);
        }
    }
}
