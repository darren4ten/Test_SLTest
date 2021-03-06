﻿using System;

namespace SourceLinkTest
{
    public class Speaker
    {
        public void Speak(String name, String msg)
        {
            Console.WriteLine($"Hello {name}, {msg} {DateTime.Now}");
        }

        public void SpeakReverse(String msg)
        {
            Console.WriteLine("// check empty");
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            var strs = msg.Split(' ');
            Array.Reverse(strs);
            Console.WriteLine($"Your orginal msg is `{msg}` \r\n__{DateTime.Now}");
            Console.WriteLine($"Reversed msg is `{String.Join(" ", strs)}`\r\n__{DateTime.Now}");
            Console.WriteLine("//todo.split");
            Console.WriteLine("-------------------------------");
        }
    }
}
