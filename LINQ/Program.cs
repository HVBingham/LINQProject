using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var getWords = words.Where(w => w.Contains("th"));
            foreach(var word in getWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var getNames = names.Distinct();
            foreach(var name in getNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var secondList = new List<double>();
            double averageClassGrade = 0;
            for(int i = 0; i < classGrades.Count; i++)
            {
                var splitNumbers = classGrades[i].Split(',').Select(double.Parse).ToList();
                secondList = splitNumbers.OrderByDescending(c => c).Take(splitNumbers.Count() - 1).ToList();
                var averageGrade = secondList.Average();
                averageClassGrade += averageGrade;
            }
            double finalAverage = averageClassGrade / secondList.Count;
            Console.WriteLine(finalAverage);
            Console.ReadLine();
        }
    }
}
    

