using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class TruckTour
    {
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int sum = 0;
            int startIndex = 0;
            for (int i = 0; i < petrolpumps.Count; i++)
            {
                int petrol = petrolpumps[i][0];
                int distance = petrolpumps[i][1];
                sum += petrol - distance;

                if (sum < 0)
                {
                    sum = 0;
                    startIndex = i + 1;
                }
            }

            return startIndex;
        }

        [Fact]
        public static void truckTour_Test() 
        {
            var list = new List<List<int>>()
            {
                new List<int>() { 1, 5, },
                new List<int>() { 10, 3 },
                new List<int>() { 3, 4 },
            };

            var result = truckTour(list);
            Assert.NotNull(result);
        }
    }
}
