using System;
using System.Text.RegularExpressions;

namespace ReplaceТags
{
    class ReplaceТags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Regex.Replace(input, @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>", "[$2]($1)");
            Console.WriteLine(output);
        }
    }
}
