using System;
using System.Collections.Generic;
using System.Text;

namespace 接口
{
    class Plane:IFly //将plane这个类与接口IFly连接上
    {
        public void Fly()  //要求飞机这个类要实现接口中的两个方法
        {
            Console.WriteLine("飞机在飞");
        }
        public void FlyAttack()
        {
            Console.WriteLine("飞机在空中攻击");
        }
    }
}
