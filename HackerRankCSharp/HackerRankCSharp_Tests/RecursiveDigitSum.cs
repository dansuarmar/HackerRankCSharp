using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class RecursiveDigitSum
    {
        public static int superDigit(string n, int k)
        {
            Int64 result = 0;
            n = n.Trim();
            for (int i = 0; i < n.Length; i++)
            {
                var int1 = Convert.ToInt32(n[i] - '0');
                result += int1 * k;
            }

            if (result.ToString().Length > 0)
                result = CalculateSuperDigit(result);

            return (int)result;
        }

        private static int CalculateSuperDigit(Int64 baseInt)
        {
            var result = 0;
            var baseString = baseInt.ToString();

            foreach (var number in baseString)
            {
                result += Convert.ToInt32(number) - '0';
            }

            if(result.ToString().Length > 1)
                result = CalculateSuperDigit(result);
            
            return result;
        }

        [Fact]
        public void superDigit_Test() 
        {
            var n = "148";
            var k = 3;
            var result = superDigit(n, k);
            Assert.Equal(3, result);
        }
    }
}
