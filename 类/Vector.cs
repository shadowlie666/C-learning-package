using System;
using System.Collections.Generic;
using System.Text;

namespace 类
{
    class Vector
    {
        private float x;   //定义一个私有成员，无法通过vector.x访问成员信息
        private float y;
        private float z;

        public void setx(float temp)
        {
            if(temp<0)  //可以对成员x的值进行限制，确保x一定大于0
            {
                return;
            }
            x = temp;  //可以通过一个公有的函数成员来修改类中私有变量成员的值
        }
        public void sety(float temp)
        {
            y = temp;
        }
        public void setz(float temp)
        {
            z = temp;
        }
        public float getx()  //通过公有的函数成员返回私有成员的数据
        {
            return x;
        }

        public double length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
