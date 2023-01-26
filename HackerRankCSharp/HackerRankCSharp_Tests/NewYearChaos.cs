using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public  class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {
            int totalBribes = 0;
            for (var i = q.Count - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i]) totalBribes++;
            }

            Console.WriteLine(totalBribes);
        }

        [Fact]
        public static void minimumBribes_Test() 
        {
            var list1 = new List<int>() { 2, 1, 5, 3, 4 };
            var list2 = new List<int>() { 2, 5, 1, 3, 4 };
            minimumBribes(list1);
            minimumBribes(list2);
        }
    }
}
