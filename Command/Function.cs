using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CloseFunction
    {
        public void CloseFile()
        {
            Console.WriteLine("启动关闭文件");
        }
    }
    class OpenFunction
    {
        public void OpenFile()
        {
            Console.WriteLine("启动打开文件");
        }
    }
    class DestroyFunction
    {
        public void DestoryFile()
        {
            Console.WriteLine("启动销毁文件");
        }
    }
}
