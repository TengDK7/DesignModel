using System;
using System.Configuration;
using System.Reflection;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string proxy = ConfigurationManager.AppSettings["targetproxy"];
            Searcher search = (Searcher)Assembly.Load("Proxy").CreateInstance(proxy);
            search.Search(0, Word.Human);
            search.Search(20, Word.People);
            search.Search(4, Word.Human);
            search.Search(60, Word.People);
            search.Search(8, Word.Human);
            search.Search(100, Word.Person);
            search.Search(7, Word.Human);
            search.Search(6, Word.Person);
            search.Search(5, Word.Person);
            search.Search(5, Word.Human);

            Console.WriteLine();
            SecondSearchProxy searchProxy = new SecondSearchProxy();
            searchProxy.Search(1, Word.Human);
            searchProxy.Search(21, Word.Human);
            searchProxy.Search(10, Word.People);
            searchProxy.Search(-4, Word.People);
            searchProxy.Search(-7, Word.Person);
            Console.ReadKey();
        }
    }
}
