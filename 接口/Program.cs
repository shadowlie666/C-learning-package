using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane p = new Plane(); //声明类的对象
            p.Fly();
            p.FlyAttack();

            IFly a; //通过接口来声明一个对象
            a = new Plane(); //告诉我们这个接口对象连接的是plane类，这个对象就变成了Plane的对象
            a.Fly(); //他可以实现plane类里面的所有方法
            a.FlyAttack();

            Boat ba = new Boat ();
            ba.Dived(); //连接了子接口的类创造的对象既可以使用子接口本身的函数
            ba.Fly();//也可以实现父接口的函数

        }
    }
}
