using System;
using System.Collections.Generic;
using System.Text;

namespace 接口
{
    class Bird: IFly //将bird这个类与接口连接
    {
        public void Fly()  //要求鸟这个类要实现接口中的两个方法
        {
            Console.WriteLine("鸟在飞");
        }
        public void FlyAttack()
        {
            Console.WriteLine("鸟在空中攻击");
        }
    }
}
