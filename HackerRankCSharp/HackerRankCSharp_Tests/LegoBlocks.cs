using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{


    public class Result
    {
        static long[] table;
        static long[] table2;
        public static long legoBlocks(int m, int n)
        {
            table = new long[n + 1];
            table2 = new long[n + 1];
            for (int i = 0; i <= n; i++) table2[i] = -1;
            var resFill = FillTable2(n);
            for (int i = 0; i <= n; i++)
            {
                long res = 1;
                for (int j = 0; j < m; j++)
                {
                    res = (res * table2[i]) % 1000000007;
                }
                table2[i] = res;
            }
            for (int i = 0; i <= n; i++)
            {
                table[i] = -1;
            }
            long result = Helper(n);
            return result;
        }

        private static long Helper(int n)
        {
            if (table[n] == -1)
            {
                if (n == 1)
                {
                    table[n] = 1;
                }
                else
                {
                    table[n] = table2[n];
                    for (int i = 1; i < n; i++)
                    {
                        table[n] = (table[n] - Helper(n - i) * table2[i]) % 1000000007;
                    }
                    if (table[n] < 0)
                    {
                        table[n] += 1000000007;
                    }
                }
            }
            return table[n];
        }

        private static long FillTable2(long n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (table2[n] == -1)
            {
                if (n == 0)
                {
                    table2[n] = 1;
                }
                else
                {
                    table2[n] = (FillTable2(n - 1) + FillTable2(n - 2) + FillTable2(n - 3) + FillTable2(n - 4)) % 1000000007;
                }
            }
            return table2[n];
        }
    }
}
