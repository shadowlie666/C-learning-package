using System;
using 类;

namespace 继承
{
    class Program
    {
        static int i = 5;
        static int data1 = 3;
        static int data3 = 6;
        static int arg = 8;
        
        public void Main(string[] args)
        {
            BasicClass bc = new BasicClass(i); //创建父类对象
            bc.function1(); //通过父类对象使用父类功能
            bc.function2();

            DerviedClass bc1 = new DerviedClass(arg, data1, data3, i); //创建子类对象
            bc1.function1(); //子类从父类继承了成员，通过子类对象一样可以使用父类功能
            bc1.function2();

            Customers cs = new Customers(); //使用了另一个项目“类”里面的customers类创建对象

            Console.WriteLine(BasicClass.ss );//静态成员只能通过类访问 
        }
    }
}
