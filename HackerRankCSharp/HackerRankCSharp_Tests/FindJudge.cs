using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class FindJudge
    {
        //Tu Solución
        //public static int findJudge(int n, int[][] trust)
        //{
        //    if (n == 1)
        //        return 1;

        //    if (trust.Length == 0)
        //        return -1;

        //    int[] iTrustU = new int[n + 1];
        //    int[] UtrustMe = new int[n + 1];

        //    for (int i = 0; i < trust.Length; i++)
        //    {
        //        iTrustU[trust[i][0]]++;
        //        UtrustMe[trust[i][1]]++;
        //    }

        //    for (int j = 0; j < UtrustMe.Length; j++)
        //    {
        //        if (UtrustMe[j] == n - 1 && iTrustU[j] == 0)
        //            return j;
        //    }

        //    return -1;
        //}


        //Solución ChatGPT
        public static int findJudge(int n, int[][] trust)
        {
            int[] trustCounts = new int[n + 1]; // initialize trustCounts array with n+1 elements

            foreach (int[] pair in trust)
            {
                int personA = pair[0];
                int personB = pair[1];
                trustCounts[personA]--; // decrement trust count for personA
                trustCounts[personB]++; // increment trust count for personB
            }

            for (int i = 1; i <= n; i++)
            {
                if (trustCounts[i] == n - 1)
                { // check if trust count for person i is n-1
                    return i; // i is the town judge
                }
            }

            return -1;
        }
    }
}
