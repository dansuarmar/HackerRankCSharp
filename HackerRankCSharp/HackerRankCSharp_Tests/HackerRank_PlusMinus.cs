using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class HackerRank_PlusMinus
    {
        [Fact]
        public void plusMinusTest()
        {
            var nums = new List<int>()
            {
                -4, 3, -9, 0, 4, 1,
            };

            plusMinus(nums);
        }

        public static void plusMinus(List<int> arr)
        {
            List<int> positives = new();
            List<int> negatives = new();
            List<int> zeros = new();
            foreach (var val in arr)
            {
                switch (val)
                {
                    case 0:
                        zeros.Add(val);
                        break;
                    case var d when d > 0:
                        positives.Add(val);
                        break;
                    case var d when d < 0:
                        negatives.Add(val);
                        break;
                }
            }
            decimal zeroPrc = Convert.ToDecimal(zeros.Count()) / Convert.ToDecimal(arr.Count());
            decimal posPrc = Convert.ToDecimal(positives.Count()) / Convert.ToDecimal(arr.Count());
            decimal negPrc = Convert.ToDecimal(negatives.Count()) / Convert.ToDecimal(arr.Count());
            var posStr = posPrc.ToString("N6");
            var negStr = negPrc.ToString("N6");
            var zeroStr = zeroPrc.ToString("N6");
        }
    }
}
