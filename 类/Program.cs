using System;

namespace 类
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers a = new Customers(); //通过类创建一个对象（实例化对象）
            a.name = "lie";   //给类里面的成员赋值
            a.age = 19;
            a.address = "GuangZhou";
            a.createtime = "2022.7.6";

            a.Show(); //运行类中的函数成员

            //注意customers a只是声明了一个类创建的变量，只是告诉你有这么一个变量
            //并没有创建一个名字为a的变量，必须要 = new customers（）才可以说是创建了一个变量

            Vector b = new Vector();
            b.setx(2.7f);  //设置类里面成员x的值
            Console.WriteLine(b.getx() ); //输出类里面成员x的值
            //b.x = 6.7; 无法通过这种形式直接访问私有成员

            Customers c = new Customers(); //创建了一个customers的对象
                                           //会自动执行类的构造函数进行初始化
            string e = "zhangsan";
            Customers d = new Customers(e);//这个类创建的对象传递了参数，所以
                                //会运行customers类中有形参的构造函数
                    //上面那个对象c没有传递参数，运行的就是没有形参的构造函数
        }
    }
}
