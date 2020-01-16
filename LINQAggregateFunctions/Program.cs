using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAggregateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int smallestNumber = numbers.Min();

            int smallestLINQNumber = numbers.Select(number => number).Min();

            int largestLINQOddNumber = numbers.Where(number => number % 2 == 1).Max();


            int[] rangeints = numbers.Where(number => number > 4 && number < 8).ToArray();


            string sentence = "The cheese is old and moldy.";

            string[] sentenceArray = sentence.Split(' ');


            //string word = 
                
            IEnumerable<string> result = from word in sentenceArray
                                         where word.Contains("moldy")
                                         select word;

            IEnumerable<string> linqMethodResult = sentenceArray.Where(word => word.Contains("moldy"));

            string keyword = linqMethodResult.FirstOrDefault();

            Console.WriteLine("Complete");


        }
    }





}
