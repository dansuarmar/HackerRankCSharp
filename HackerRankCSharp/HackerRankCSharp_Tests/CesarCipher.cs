using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class CesarCipher
    {
        private static Dictionary<char, char> CreateCipher(int move)
        {
            if (move > 26) { 
                var mult = move / 26;
                move = move - (26*mult); 
            }

            var letDw = "abcdefghijklmnopqrstuvwxyz";
            var resp = new Dictionary<char, char>();
            for (int i = 0; i < letDw.Count(); i++)
            {
                var newIndex = i + move;
                if (newIndex > letDw.Count() - 1)
                    newIndex = newIndex - letDw.Count();
                
                resp.Add(letDw[i], letDw[newIndex]);
                resp.Add(letDw[i].ToString().ToUpper()[0], letDw[newIndex].ToString().ToUpper()[0]);
            }
            return resp;
        }

        public static string caesarCipher(string s, int k)
        {
            var resp = new StringBuilder();
            var cipher = CreateCipher(k);
            foreach (var c in s)
            {
                char value;
                if(cipher.TryGetValue(c, out value))
                    resp.Append(value);
                else
                    resp.Append(c);
            }
            return resp.ToString();
        }

        [Theory]
        [InlineData("middle-Outz", 2, "okffng-Qwvb")]
        [InlineData("www.abc.xy", 87, "fff.jkl.gh")]
        [InlineData(
            "1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M", 27, 
            "1Y7U4WsDt23l4ww08E6zR3T19H4sWQ188N9bivyC6k1uNHAt1n10fz7fVk62XW2fyMU4D83am7R80N")]
        public void CesarCipher_Test(string original, int move, string expected) 
        {
            var resp = caesarCipher(original, move);
            Assert.Equal(expected, resp);
        }
    }
}
