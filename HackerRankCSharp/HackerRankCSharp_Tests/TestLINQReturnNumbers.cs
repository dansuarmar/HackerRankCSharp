using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class TestLINQReturnNumbers
    {
        public static List<int> GetEvenNumbers(List<int> numbers, int amountOfEvenNumbersRequired) 
        {
            var result = new List<int>();
            result = numbers.Where(m => m % 2 == 0).Take(amountOfEvenNumbersRequired).ToList();

            return numbers;
        }


    }
}