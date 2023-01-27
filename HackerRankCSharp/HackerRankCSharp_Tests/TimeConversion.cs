using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            var date = DateTime.Parse(s);
            return date.ToString("HH:mm:ss");
        }
    }
}
