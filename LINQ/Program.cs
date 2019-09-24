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
          List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            var getWords = words.Where(w => w.Contains("th"));
             foreach(var word in getWords)
             {
                 Console.WriteLine(word);
             }
            Console.ReadLine();
         
            
            
        }
    }






}
    

