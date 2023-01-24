using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class HackerRank_FindMedianTest
    {
        [Fact]
        public void findMedianTest()
        {
            int[] arr = { 0, 1, 2, 4, 6, 5, 3, };
            var result = findMedian(arr.ToList());
            Assert.Equal(3, result);
        }

        public static int findMedian(List<int> arr)
        {
            var orderArr = arr.OrderBy(m => m).ToList();
            var med = orderArr.Count() / 2;
            return orderArr[med];
        }
    }
}
