using System;

namespace csharpLearning.AbstractClass
{
    public class Apple : Fruit
    {
        public override decimal Price
        {
            get
            {
                if (Name == "红富士")
                    return 100;
                else
                    return 0;
            }
        }

        public override void GrowInArea()
        {
            Console.WriteLine("我在南方北方都能生长,我的名字是:" + Name + ",我现在的价格是：" + Price);
        }

        public override string Color { get; }
        public override void GetColor()
        {
            throw new NotImplementedException();
        }
    }
}