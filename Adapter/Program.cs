using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        //适配器模式用于为满足（功能需要/方便使用）而整合现有功能接口
        static void Main(string[] args)
        {
            ObjectSearch hr = new ObjectSearch();
            List<int> source = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var tar = hr.Search(source, 7);
            var tarstr = hr.Search("searchstring", "rc");
            source.ForEach(it => Console.Write(it.ToString() + " "));
            Console.WriteLine($"中的7位于第{tar}");
            Console.WriteLine($"searchstring中的rc位于第{tarstr}");
            Console.ReadKey();
        }
    }
}
