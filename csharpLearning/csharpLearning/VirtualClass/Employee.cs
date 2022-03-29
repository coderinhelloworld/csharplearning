using System;

namespace csharpLearning.VirtualClass
{
    public class Employee
    {
        public virtual void Daka()
        {
            Console.WriteLine("员工9点打卡");
        }
        
    }
    
    public class Manager:Employee
    {
        public override void Daka()
        {
            Console.WriteLine("经理10点打卡");
        }
    }

    public class ManagerChild:Employee
    {       
        public override void Daka()
        {
            Console.WriteLine("经理小弟7点打卡");
        }
        
    }

    public class Programmer : Employee
    {
        public override void Daka()
        {
            Console.WriteLine("程序员8点打卡");
        }
    }

}