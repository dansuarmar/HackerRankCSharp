using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class Pairs
    {
        public static int pairs(int k, List<int> arr)
        {
            arr.Sort();
            var totals = 0;

            foreach (int i in arr)
            {
                int numberToSearch = i - k;
                if (Array.BinarySearch(arr.ToArray(), numberToSearch) > -1)
                {
                    totals++;
                }
            }

            return totals;
        }

        [Fact]
        public void pairs_Test() 
        {
            var arr = new List<int>() { 1, 5, 3, 4, 2, };
            var k = 2;
            var result = pairs(k, arr);
            Assert.Equal(3, result);
        }
    }
}
