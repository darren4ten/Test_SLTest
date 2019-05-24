using System;

namespace SourceLinkTest
{
    public class Speaker1
    {
        public void SpeakReverseV1(String msg)
        {
            Console.WriteLine("// check empty 2019-5-24 10:06:59");
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
