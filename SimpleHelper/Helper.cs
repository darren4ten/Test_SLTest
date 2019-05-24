using System;

namespace SimpleHelper
{
    public class Helper
    {
        public void Talk(String msg)
        {
            var helloMsg = "Hello " + msg;
            var timeMsg = "Now is " + DateTime.Now;
            Console.WriteLine(helloMsg);
            Console.WriteLine(timeMsg);
            Console.WriteLine("---------------");
        }
    }
}
