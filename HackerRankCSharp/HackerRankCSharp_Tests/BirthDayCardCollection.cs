using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class BirthDayCardCollection
    {
        [Fact]
        public static void hackerCards_Test() 
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var result = hackerCards(list, 5);
            Assert.Equal(1, result.Count);
        }

        public static List<int> hackerCards(List<int> collection, int d)
        {
            var result = new List<int>();
            int sum = 0;
            for(int i = 1; i < d + 1; i++)
            {
                if (collection.Contains(i))
                    continue;
                if (sum + i > d) 
                    break;
                sum += i;
                result.Add(i);
            }
            return result;
        }
    }
}
