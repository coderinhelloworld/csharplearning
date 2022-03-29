using System;

namespace csharpLearning.AbstractClass
{
    public static class AbstractMethod
    {
        public static void ShowAbstractMethod()
        {
                  
            Fruit f = new Apple();
            f.Name = "红富士";
            f.GrowInArea();

            f = new Orange();
            f.Name = "柑橘";
            f.GrowInArea();
        }
    }
}