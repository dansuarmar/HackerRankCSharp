using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class JeseeAndCookies
    {
        public static int cookies(int k, List<int> A)
        {
            int returnVal = 0;
            PriorityQueue<int, int> queue = new();

            foreach (var item in A)
                queue.Enqueue(item, item);

            while (true)
            {
                if (queue.Peek() >= k)
                    return returnVal;
                if ((queue.Count == 1 && queue.Peek() < k))
                    return -1;

                int num1 = queue.Dequeue();
                int num2 = queue.Dequeue();
                var newVal = num1 + 2 * num2;
                queue.Enqueue(newVal, newVal);
                returnVal++;
            }
        }
    }
}
