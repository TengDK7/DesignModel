using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    enum FruitType
    {
        Apple,
        Banana,
        Orange
    }
    class FruitFactory
    {
        /// <summary>
        /// 简单工厂
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static FruitProduct CreateFruit(FruitType type)
        {
            switch(type)
            {
                case FruitType.Apple:
                    return new Apple();
                case FruitType.Banana:
                    return new Banana();
                case FruitType.Orange:
                    return new Orange();
            }
            return null;
        }
    }
}
