using System;

namespace csharpLearning.AbstractClass
{
    
    //抽象类继承抽象类不用实现其方法和属性，继承接口则要
    public  abstract class  Fruit:AbstractFruitParent,IFruit{
        //抽象属性子类必须重写
        public abstract   decimal Price { get;}
        //可以声明非抽象的属性
        public  string Name { get; set; }
        //抽象方法必须是公有的,子类必须重写
        public abstract void GrowInArea();

        //可以声明非抽象的方法
        public  void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }
        //也可以有私有方法，但是无意义
        private  void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod");
        }

        public decimal GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}