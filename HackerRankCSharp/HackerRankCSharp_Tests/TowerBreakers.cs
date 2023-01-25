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
            switch (n) 
            {
                case var d when d % 2 == 1:
                    return 1;
                default: 
                    return 2;
            }
        }
    }
}
