
using System;
using System.Threading;

class GFG
{
    static void Main(string[] args)
    {
 
        Thread thr = new Thread(mythread);
        thr.Start();
        thr.IsBackground = true;
        Console.WriteLine("Main Thread Ends!!");
    }
    static void mythread()
    {

        for (int i = 0; i < 2; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine("Main thread running...");
        }
    }
}
