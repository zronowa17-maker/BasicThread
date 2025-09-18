using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BasicThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopcount = 0; loopcount <= 5; loopcount++)
            {
                Console.WriteLine("Name Of Thread: " + Thread.CurrentThread.Name + " = " + loopcount);
                Thread.Sleep(1500);
            }
        }
    }
}
         
            
  


