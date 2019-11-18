using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPracticeProblems
{
    public class LINQ
    {
        //1. Using LINQ, write a function that returns all words that contain the substring “th” from a list.
        //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };
        delegate bool StringToBoolFunction(string word);

        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            words = words.Where(w => w.Contains("th")).ToList();
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
        }

        //2. Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
        //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

    }
}
