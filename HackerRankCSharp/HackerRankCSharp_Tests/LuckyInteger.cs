using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class LuckyInteger
    {
        public static int FindLuckyNumber(int[] arr) 
        {
            var arrOrd = arr.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < arr.Count(); i++) 
            {
                if (arrOrd[i] == arrOrd.Where(x => x == arrOrd[i]).Count())
                    return arrOrd[i];
            }
            return -1;
        }

        [Fact]
        public void FindLuckyNumber_Test() 
        {
            var arrOrd = new[] { 9, 2, 3, 9, 2, 2, 3, 8, 9, 9, 9, 9, 9, 9, 1, 0, 10, 9 };
            var result = FindLuckyNumber(arrOrd);
        }
    }
}
