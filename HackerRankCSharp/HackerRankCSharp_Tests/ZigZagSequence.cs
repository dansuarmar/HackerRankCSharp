using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class ZigZagSequence
    {
        public static string findZigZagSequence(int[] a, int n)
        {
            var result = "";
            a.ToList().Sort();

            int mid = n / 2;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st++;
                ed--;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) result += " ";
                result += a[i].ToString();
            }
            return result;
        }
    }
}
