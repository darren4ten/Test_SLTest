using System;

namespace SourceLinkTestV3
{
    public class PeopleV3
    {
        /// <summary>
        /// talk to somebody v3
        /// </summary>
        /// <param name="msg">message</param>
        public void Talk(String msg)
        {
            //welcome msg
            var hello = "1.0.2 Hello " + msg;
            //time
            var time = "Now is " + DateTime.Now;
            Console.WriteLine(hello);
            Console.WriteLine(time);
            Console.WriteLine("--------------");
        }
    }
}
