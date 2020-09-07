using System;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Day05();
            var result = test.solution(new string[] { "abce", "abcd", "cdx"}, 2);
            Console.WriteLine("result = {0}", result);
        }
    }
}
