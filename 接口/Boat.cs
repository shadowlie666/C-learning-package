using System;
using System.Collections.Generic;
using System.Text;

namespace 接口
{
    class Boat:Dive //boat类连接了dive接口，而dive接口继承了ifly接口，那么boat类就要把两个接口的方法
    {                   //都得写了
        public void Dived()
        {
            Console.WriteLine("船在下潜");
        }
        public void Fly()
        {
            Console.WriteLine("船在飞");
        }
        public void FlyAttack()
        {
            Console.WriteLine("船在空中攻击");
        }
    }
}
