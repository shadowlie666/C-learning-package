using System;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA<int> a = new ClassA<int>(45, 65); //创造泛型类的对象
            //指明了泛型类中的数据类型为int，那么其返回值也就是int类型的
            Console.WriteLine(a.GetSum()); //调用泛型类里面的方法

            Student s = new Student(30, "李华");
            Console.WriteLine(s.ToString()); 
        }
    }

    class Student
    {
        private int age;
        private string name;

        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString() //重写Tostring方法
        {
            string result = name + ":" + age;
            return result;
        }
    }

    class ClassA<T>   //定义一个数据类型为T的泛型类
    {
        private T a;
        private T b;

        public ClassA(T a, T b)  //构造函数，这个类的对象实例化时要传递两个参数
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()   //获得和的方法
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic num = num1 + num2;
            return (T)num;
        }
    }
}
