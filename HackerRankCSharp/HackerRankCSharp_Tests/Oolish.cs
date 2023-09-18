using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class Oolish
    {
        public static int CountVowels(string input) 
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach(char c in input) 
            {
                if(vowels.Contains(c))
                    count++;
            }

            return count;
        }

        [Fact]
        public void CountVowels_Test() 
        {
            string input = "The quick brOwn fOx";
            Assert.Equal(5, CountVowels(input));

            string input2 = "Hello World";
            Assert.Equal(3, CountVowels(input2));
         }
    }
}
