using System;

namespace SourceLinkTestV2
{
    public class People
    {
        /// <summary>
        /// talk to somebody
        /// </summary>
        /// <param name="msg">message</param>
        public void Talk(String msg) {
            //welcome msg
            var hello = "1.0.3 Hello " + msg;
            //time
            var time = "Now is " + DateTime.Now;
            Console.WriteLine(hello);
            Console.WriteLine(time);
            Console.WriteLine("--------------");
        }
    }
}
