using System;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer zhangsan = new Customer() ;

            zhangsan.Age = 34; //可以通过直接访问属性，来调用属性里的set方法修改私有成员的值
            Console.WriteLine(zhangsan.Age); //当通过属性使用cw时会自动调用属性里的get方法返回私有成员数据
        }
    }
}
