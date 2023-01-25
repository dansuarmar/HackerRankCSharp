using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class LonelyInteger
    {


        public static int lonelyinteger(List<int> a)
        {
            for (var i = 0; i < a.Count; i++) 
            {
                var repeat = false;
                for (var si = 0; si < a.Count; si++) 
                {
                    if (a[i] == a[si] && i != si)
                        repeat = true;
                }
                if(repeat == false)
                    return a[i];
            }
            return -1;
        }

        [Theory]
        [ClassData(typeof(LonelyIntegerData))]
        public static void lonelyInteger_Test(List<int> testArr, int expected) 
        {
            var result = lonelyinteger(testArr);
            Assert.Equal(expected, result);
        }

        public class LonelyIntegerData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new List<int>() { 1, 2, 3, 4, 3, 2, 1 }, 4 };
                yield return new object[] { new List<int>() { 1, 1, 2 }, 2 };
                yield return new object[] { new List<int>() { 0, 0, 1, 2, 1 }, 2 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
