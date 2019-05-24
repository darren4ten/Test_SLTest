using System;

namespace SourceLinkTestV2
{
    public class People
    {
        public void Talk(String msg) {
            var hello = "Hello " + msg;
            var time = "Now is " + DateTime.Now;
            Console.WriteLine(hello);
            Console.WriteLine(time);
            Console.WriteLine("--------------");
        }
    }
}
