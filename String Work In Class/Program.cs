using System;

namespace String_Work_In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string together = string.Concat("this is the first part of the sentence, ", "this is the second part of the sentence");
            Console.WriteLine(together);

            bool isEqual = together.Equals("this is not a string");
            Console.WriteLine($"{together} equals 'this is not a string': {isEqual}");

            int isSame = string.Compare("cat", "dog");
            Console.WriteLine($"cat == dog " + isSame);

            isSame = string.Compare("dog", "cat");
            Console.WriteLine($"dog == cat " + isSame);

            int index = together.IndexOf("is");
            Console.WriteLine($"expected: 2, actual: {index}");

            index = together.LastIndexOf("is");
            Console.WriteLine($"exptected: 30ish, actual: {index}");

            bool endsWith = together.EndsWith('!');
            Console.WriteLine($"expected: false, actual: {endsWith}");

            string newTogether = together.ToLower().Replace("this", "");
            Console.WriteLine(newTogether);

            string[] togetherArray = together.Split();
            foreach(string word in togetherArray)
            {
                Console.WriteLine(word);
            }

            index = together.LastIndexOf("this");

            string togetherPartTwo = together.Substring(index);
            Console.WriteLine(togetherPartTwo);

            string shorterTogetherPartTwo = together.Substring(index, 5);
            Console.WriteLine(shorterTogetherPartTwo);

            string beginningTogether = together.Substring(0, index);
            Console.WriteLine(beginningTogether);
        }

    }
}
