using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class SimpleArraySum
    {
        public static int simpleArraySum(List<int> ar)
        {
            //int sum = 0;
            //foreach (int i in ar) 
            //{
            //    sum += i;
            //}
            //return sum;
            return ar.Sum();
        }


    }
}
