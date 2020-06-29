using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    enum Word
    {
        People,
        Person,
        Human,
    }
    abstract class Searcher
    {
        public abstract string Search(int ID,Word word);
    }
    class SearchSystem : Searcher
    {
        public override string Search(int ID,Word word)
        {
            switch(word)
            {
                case Word.Human:
                    return "人类";
                case Word.People:
                    return "人们";
                case Word.Person:
                    return "个人";
                default:
                    return "";
            }
        }
    }
    class SearchProxy:Searcher
    {
        private SearchSystem searchSystem = new SearchSystem();
        private Validate validate = new Validate();
        private SearchLog log = new SearchLog();

        public override string Search(int ID,Word word)
        {
            if(validate.IsValid(ID))
            {
                log.Log(ID, word);
                return searchSystem.Search(ID, word);
            }
            return null;
        }
    }
    class SecondSearchProxy : Searcher
    {
        private SearchSystem searchSystem = new SearchSystem();
        public override string Search(int ID, Word word)
        {
            var result = searchSystem.Search(ID, word);
            Console.WriteLine($"用户{ID}查询{word}的结果为{result}");
            return result;
        }
    }
}
