using System;
using System.Collections.Generic;
using System.Text;

namespace 类  //namespace为类名
{               //一个类中可以有多个函数成员
    public class Customers
    {
        //数据成员
        public string name;
        public string address;
        public int age;
        public string createtime;

        //函数成员
        public void Show()
        {
            Console.WriteLine("名字" + name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + createtime);
        }

        public Customers ()//构造函数，当通过类创造一个对象的时候，这个对象会
        {                   //自动执行这个函数进行初始化
            Console.WriteLine("我是构造函数");
        }

        public Customers (string a) //构造函数可以有多个（函数的重载）
        {               //对象初始化只会运行匹配的构造函数
            name = a;
        }

        public Customers(string name, string address, int age, string createtime)
        {
            this.name = name;  //this.name代表类中的数据成员，是第十行的name
            this.address = address; //name代表的是构造函数中的形参，是第34行的name
            this.age = age;
            this.createtime = createtime;
        }
    }
}
