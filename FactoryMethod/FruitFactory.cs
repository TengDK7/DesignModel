using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    #region FruitFactory
    abstract class FruitFactory
    {
        public abstract FruitProduct CreateFruit();
    }
    class AppleFactory : FruitFactory
    {
        public override FruitProduct CreateFruit()
        {
            return new Apple();
        }
    }
    class BananaFactory:FruitFactory
    {
        public override FruitProduct CreateFruit()
        {
            return new Banana();
        }
    }
    class OrangeFactory:FruitFactory
    {
        public override FruitProduct CreateFruit()
        {
            return new Orange();
        }
    }
    #endregion

    #region FruitFactoryEx
    abstract class FruitFactoryEx
    {
        FruitProduct fruit;
        public abstract FruitProduct CreateFruit();
        public string GetProductName()
        {
            if (fruit == null)
                fruit = this.CreateFruit();
            return fruit.GetProductName();
        }
        public string GetProductType()
        {
            if (fruit == null)
                fruit = this.CreateFruit();
            return fruit.GetProductType();
        }
    }
    class AppleFactoryEx : FruitFactoryEx
    {
        public override FruitProduct CreateFruit()
        {
            return new Apple();
        }
    }
    class BananaFactoryEx : FruitFactoryEx
    {
        public override FruitProduct CreateFruit()
        {
            return new Banana();
        }
    }
    class OrangeFactoryEx : FruitFactoryEx
    {
        public override FruitProduct CreateFruit()
        {
            return new Orange();
        }
    }
    #endregion
}
