using System;
using System.Collections.Generic;
using System.Text;

namespace 继承
{
    class BasicClass //该类为父类
    {
        public int data1;
        private string data2;
        protected float data3;
        public int i;
        public static int ss = 6;

        public static void Ss() 
        {
            ss = 7;          //静态函数只能使用静态成员
            //data1 = 6;
        }

        public virtual void function1() //virtual表示该函数在子类中有重写
        {
            Console.WriteLine("使用父类功能一");
        }
        public void function2()
        {
            Console.WriteLine("使用父类功能二");
        }

        public BasicClass (int i)
        {
            this.i = i;
        }
    }
}
