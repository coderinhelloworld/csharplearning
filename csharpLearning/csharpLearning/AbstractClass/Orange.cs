using System;

namespace csharpLearning.AbstractClass
{
    public class Orange : Fruit
    {
        public override decimal Price
        {
            get { return 0; }
        }

        public override void GrowInArea()
        {
            Console.WriteLine("我只能生长在南方,我的名字是:" + Name + ",我现在的价格是：" + Price);
        }

        public override string Color { get; }
        
        public override void GetColor()
        {
            throw new NotImplementedException();
        }
    }
}