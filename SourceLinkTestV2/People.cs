﻿using System;

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
            var hello = "2019-5-24 11:25:34 Hello " + msg;
            //time
            var time = "Now is " + DateTime.Now;
            Console.WriteLine(hello);
            Console.WriteLine(time);
            Console.WriteLine("--------------");
        }
    }
}
