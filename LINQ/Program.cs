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
            //1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var getWords = words.Where(w => w.Contains("th"));
            foreach(var word in getWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            //2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var getNames = names.Distinct();
            foreach(var name in getNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            //3
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"

            };
            var secondList = new List<double>();
            double averageCGrade = 0;
            double finalAverage = 0;
            for(int i=0; i < classGrades.Count; i++)
            {
                var splitIt = classGrades[i].Split(',').Select(double.Parse).ToList();
                secondList= splitIt.OrderByDescending(s => s).Take(splitIt.Count()-1).ToList();
                var averageGrade = secondList.Average();
                averageCGrade += averageGrade;  
            }
            finalAverage = averageCGrade / secondList.Count;
            Console.WriteLine(finalAverage);
            Console.ReadLine();
            //4
            
          
        }
    }
}
    

