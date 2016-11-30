using System;
using System.Text;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();
           
            foreach (var sentence in sentences)
            {
                temp.Clear();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) == false)
                    {
                        temp.Append(sentence[i]); 
                    }
                }
                char[] splitChars = temp.ToString().ToCharArray();
                string[] words = sentence.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                if (Array.IndexOf(words, word) > -1)
                {
                    result.Append(sentence.Trim());
                    result.Append(". ");
                }
            }
            
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
