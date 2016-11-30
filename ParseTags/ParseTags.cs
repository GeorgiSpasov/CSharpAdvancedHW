using System;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string upStrStart = "<upcase>";
            string upStrEnd = "</upcase>";
            char[] inputAsChar = input.ToCharArray();
            
            ConvertToUpper(input, upStrStart, upStrEnd, inputAsChar);
            string result = new string(inputAsChar);
            result = result.Replace(upStrStart, "");
            result = result.Replace(upStrEnd, "");
            
            Console.WriteLine(result);
        }

        private static void ConvertToUpper(string input, string upStrStart, string upStrEnd, char[] inputAsChar)
        {
            int indexStart = -1;
            int indexEnd = -1;
            for (int i = 0; i < input.Length; i++)
            {
                indexStart = input.IndexOf(upStrStart, indexStart + 1);
                if (indexStart != -1)
                {
                    indexEnd = input.IndexOf(upStrEnd, indexEnd + 1);
                    for (int j = indexStart + upStrStart.Length; j < indexEnd; j++)
                    {
                        string temp = input[j].ToString().ToUpper();
                        inputAsChar[j] = Convert.ToChar(temp);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
