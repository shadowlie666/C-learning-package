using System;
using System.Threading;

namespace 线程
{
    class Program
    {
        private static bool a = true;

        static void Main(string[] args)
        {
            Thread ct  = new Thread(new ThreadStart(ChildThread));
            //在main方法里面创造另一个线程的对象
            ct.Start(); //运行另一个线程

            Thread.Sleep(1);  //让main所在的线程暂停1ms
            ct.Abort();  //让ct对象所对应的ChildThread线程终止运行

            a = false;
        }

        private static void ChildThread() //创造一个线程
        {
            while(true)
            {
                Console.WriteLine("ChildThread is running");
            }
            
        }
    }
}
