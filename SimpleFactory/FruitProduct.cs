using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    abstract class FruitProduct
    {
        public string GetProductType()
        {
            return "水果";
        }
        public abstract string GetProductName();
    }
    class Apple : FruitProduct
    {
        public override string GetProductName()
        {
            return "苹果";
        }
    }
    class Banana : FruitProduct
    {
        public override string GetProductName()
        {
            return "香蕉";
        }
    }
    class Orange : FruitProduct
    {
        public override string GetProductName()
        {
            return "橘子";
        }
    }
}
