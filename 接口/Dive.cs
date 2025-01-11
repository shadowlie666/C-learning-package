using System;
using System.Collections.Generic;
using System.Text;

namespace 接口
{
    interface Dive:IFly //接口也可以继承，这样接口dive连接的类就必须把这个接口的父接口ifly的函数也给写了
    {
        public void Dived();
    }
}
