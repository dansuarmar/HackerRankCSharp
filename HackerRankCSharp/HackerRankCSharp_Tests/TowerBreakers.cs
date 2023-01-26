using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class TowerBreakers
    {
        public static int towerBreakers(int n, int m)
        {
            if(m == 1) return 2;

            if(n % 2 == 1)
                return 1;

            return 2;
        }
    }
}
