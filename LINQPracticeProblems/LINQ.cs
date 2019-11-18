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
        

        public void FindSubString()
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
        public void ReturnListWithoutDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            names = names.Distinct().ToList();
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

        //3. Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest 
        //grade from each string, averages the rest of the grades from that string, then averages the averages.
        //List<string> classGrades = new List<string>()
        //{
        //"80,100,92,89,65",
        //"93,81,78,84,69",
        //"73,88,83,99,64",
        //"98,100,66,74,55"
        //};
        //        Expected output: 86.125


        public static string[] RemoveLowestNumber(string item)
        {
            //convert all indexes to an array of ints
            var output = item.Split(',').OrderBy(i => int.Parse(i)).ToList();
            output.RemoveAt(0);
            return output.ToArray();
        }

        //average remaining ints in new output array
        public static GetAverageGradesOfStudent()





    }
}
