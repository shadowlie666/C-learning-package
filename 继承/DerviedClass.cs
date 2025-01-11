using System;
using System.Collections.Generic;
using System.Text;

namespace 继承
{
    class DerviedClass : BasicClass
    { //该子类继承了父类的所有成员，包括其数据成员和函数成员
        public int arg = 4; //除了从父类继承的成员，子类可以有自己的一些成员

        public DerviedClass (int arg, int data1, int data3, int i):base(i) //构造函数
        {                       //这里的base(i)表示把形参i传递到父类的构造函数里面去使用，其他参数在子类使用
            this.arg = arg; 
            this.data1 = data1; //可以通过this修改父类的成员信息
            base.data3 = data3; //也可以通过base修改父类的成员信息
            //base只能对父类里面的成员进行赋值，不能对子类的成员赋值
        }

        public void As()
        {
            Console.WriteLine("使用子类功能");
            
        }

        public void Ad() //子类可以访问父类中的public和protected成员
        {
            Console.WriteLine("data:" + data1 );
            Console.WriteLine("data:" + data3 );
        }

        public override void function1()//虚方法重写从父类中继承的function1函数
        {
            Console.WriteLine("使用子类功能一");
        }

        public new void function2()//隐藏方法重写从父类中继承的function2函数
        {
            Console.WriteLine("使用子类功能二");
        }

    }
}
