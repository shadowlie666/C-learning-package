using System;
using System.Collections.Generic;
using System.Text;

namespace 属性
{
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string createtime;

        public void Show()
        {
            Console.WriteLine("名字" + name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + createtime);
        }

        public int Age //属性的定义，和函数类似，就是没有后面那个括号
        {
            set   //属性里面包括两个成员set和get
            {
                age = value; //set可以修改类中的私有成员，set默认接收的形参叫value
            }
            get  //get可以返回类中的私有数据成员数据回去
            {
                return age;
            }
        }
        //使用属性就不需要在类里面设置两个函数来访问私有成员了
    }
}
