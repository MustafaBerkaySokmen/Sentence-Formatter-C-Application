using System;

namespace PunctuationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumped over the lazy dog.";

            Console.WriteLine("Original sentence: {0}", sentence);
            Console.WriteLine();

            // Add punctuation marks to the sentence
            sentence = sentence.Insert(3, ",");
            sentence = sentence.Insert(9, ".");
            sentence = sentence.Insert(19, "!");
            sentence = sentence.Insert(27, "?");
            sentence = sentence.Insert(32, ";");

            Console.WriteLine("Modified sentence: {0}", sentence);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
