using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum1 += arr[i][i];
                sum2 += arr[i][arr.Count - 1 - i];
            }

            return Math.Abs(sum1 - sum2);
        }

        [Fact]
        public static void DiagonalDifference_Test() 
        {
            var arr = new List<List<int>>() 
            {
                new List<int>(){ 11, 2, 4 },
                new List<int>(){ 4, 5, 6 },
                new List<int>(){ 10, 8, -12 },
            };

            var result = diagonalDifference(arr);

            Assert.Equal(15, result);  
        }

    }
}
