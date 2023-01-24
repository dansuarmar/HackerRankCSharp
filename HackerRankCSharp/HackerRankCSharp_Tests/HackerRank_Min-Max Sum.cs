using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class HackerRank_Min_Max_Sum
    {
        public class MinMaxSumTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new List<int>() { 1, 2, 3, 4, 5 }, "10 14" };
                yield return new object[] { new List<int>() { 1, 3, 5, 7, 9 }, "16 24" };
                yield return new object[] { new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 }, "2063136757 2744467344" };
                yield return new object[] { new List<int>() { 5, 5, 5, 5, 5 }, "20 20" };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


        [Theory]
        [ClassData(typeof(MinMaxSumTestData))]
        public void minMaxSumTest(List<int> arr, string expected)
        {
            var result = miniMaxSum(arr.ToList());
            Assert.Equal(expected, result);
        }

        public static string miniMaxSum(List<int> arr)
        {
            int maxValue = 0;
            List<long> results = new();
            for (var i = 0; i < arr.Count(); i++)
            {
                var ltoSent = arr.Select(m => Convert.ToInt64(m)).ToList();
                ltoSent.Remove(ltoSent[i]);
                var sumResult = SumArray(ltoSent);
                results.Add(sumResult);
            }
            return results.Min() + " " + results.Max();
        }

        public static long SumArray(List<long> arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += Convert.ToInt64(item);
            }
            return sum;
        }
    }
}
