using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class HackerRank_TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime originalDate;
            DateTime.TryParse(s, out originalDate);
            return originalDate.ToString("HH:mm:ss");
        }

        [Fact]
        public void TimeConversion_Test()
        {
            DateTime timeToTest;
            var result = timeConversion("12:55:37PM");
            Assert.Equal("12:55:37", result);
        }
    }
}
