using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class PalinndromeIndex
    {
        //public static int palindromeIndex(string s)
        //{
        //    if(s.Count() == 0 || IsPalindrome(s))
        //        return -1;

        //    for (int i = 0; i < s.Count() / 2; i++) 
        //    {
        //        var strToTest = s.Remove(i, 1);
        //        if(IsPalindrome(strToTest))
        //            return i;
        //    }

        //    return -1;
        //}

        //public static bool IsPalindrome(string s) 
        //{
        //    if (s.Count() % 2 == 1) 
        //    {
        //        var div1 = s.Count() / 2;
        //        s = s.Remove(s.Count() / 2, 1);
        //    }

        //    var div = s.Count() / 2;
        //    var left = s.Substring(0, div);
        //    var rightArr = s.Substring(div, div).ToCharArray().Reverse();
        //    var right = new string(rightArr.ToArray());
        //    return left == right;
        //}

        public static int palindromeIndex(string s)
        {
            int max = s.Length / 2;

            for (int i = 0; i < max; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    if (s.Substring(i + 1, 2) == Reverse(s.Substring((s.Length - 1 - i) - 1, 2)))
                        return i;
                    else
                        return (s.Length - 1 - i);
                }
            }

            return -1;
        }

        public static string Reverse(string str)
        {
            var arr = str.ToCharArray().Reverse().ToArray();
            return new string(arr);
        }

        [Theory]
        [InlineData("aaab", 3)]
        [InlineData("baaa", 0)]
        [InlineData("aaa", -1)]
        [InlineData("", -1)]
        [InlineData("quyjjdcgsvvsgcdjjyq", 1)]
        public static void PalinndromeIndex_Test(string source, int expected) 
        {
            var result = palindromeIndex(source);
            Assert.Equal(result, expected);
        }
    }
}
