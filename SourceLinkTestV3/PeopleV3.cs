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
            var hello = "2019-5-24 11:32:09 Hello " + msg;
            //time
            var time = "Now is " + DateTime.Now;
            Console.WriteLine(hello);
            Console.WriteLine(time);
            Console.WriteLine("--------------");
        }
    }
}
