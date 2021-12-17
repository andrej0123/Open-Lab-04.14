using System;
using System.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string longest = strings.OrderByDescending(s => s.Length).First();

            string a = "";
            string b = "";

            for (int i = 0; i < longest.Length + 4; i++)
            {
                a += "*";
            }
            Console.WriteLine($"{a}");

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == longest.Length)
                {
                    Console.WriteLine($"* {strings[i]} *");
                }
                else
                {
                    for (int j = 0; strings[i].Length < longest.Length; j++)
                    {
                        strings[i] += " ";
                    }
                    Console.WriteLine($"* {strings[i]} *");
                }
            }

            for (int i = 0; i < longest.Length + 4; i++)
            {
                 b += "*";
            }
            Console.WriteLine($"{b}");
        }

    }
}