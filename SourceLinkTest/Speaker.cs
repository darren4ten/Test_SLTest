using System;

namespace SourceLinkTest
{
    public class Speaker
    {
        public void Speak(String name, String msg)
        {
            Console.WriteLine($"Hello {name}, {msg} {DateTime.Now}");
        }
    }
}
