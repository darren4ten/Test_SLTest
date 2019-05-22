using System;

namespace SourceLinkTest_snupkg
{
    public class Speaker
    {
        public void Speak(String name, String msg)
        {
            Console.WriteLine($"Hello {name}, {msg} {DateTime.Now}");
        }

        public void SpeakReverse(String msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            var strs = msg.Split(' ');
            Array.Reverse(strs);
            Console.WriteLine($"Your orginal msg is `{msg}` \r\n__{DateTime.Now}");
            Console.WriteLine($"Reversed msg is `{String.Join(" ", strs)}`\r\n__{DateTime.Now}");

            Console.WriteLine($"-------------{GetNamespaceInfo()}------------------");
        }

        public string GetNamespaceInfo()
        {
            var type = this.GetType();
            return type.Namespace + "--" + type.Name;
        }
    }
}
