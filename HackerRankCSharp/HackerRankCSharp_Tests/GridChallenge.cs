using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class GridChallenge
    {
        public static bool isAlphabetical(string text) 
        {
            var strChar = new string(text.ToCharArray().OrderBy(x => x).ToArray());
            if(strChar != text)
                return false;

            return true;
        }

        public static string gridChallenge(List<string> grid)
        {
            List<string> result = new List<string>();
            var cols = new List<string>();
            foreach (var item in grid)
            {
                result.Add(new string(item.OrderBy(x => x).ToArray()));
            }

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < grid[i].Count(); j++)
                {
                    if (j >= cols.Count)
                        cols.Add("");

                    cols[j] += result[i][j];
                }
            }

            foreach (var item in cols)
            {
                if (!isAlphabetical(item))
                    return "NO";
            }
            return "YES";
        }

        //public static string gridChallenge(List<string> grid)
        //{
        //    List<string> sortedList = new List<string>();
        //    char[] lineChars;
        //    int trueColTotal;

        //    foreach (string item in grid)
        //    {
        //        lineChars = item.ToArray();
        //        Array.Sort(lineChars);
        //        sortedList.Add(new string(lineChars));
        //    }
        //    trueColTotal = sortedList[0].Length;
        //    for (int col = 0; col < trueColTotal; col++)
        //    {
        //        for (int row = 0; row < sortedList.Count() - 1; row++)
        //        {
        //            var t1 = Convert.ToChar(sortedList[row].Substring(col, 1).ToLower());
        //            var t2 = Convert.ToChar(sortedList[row + 1].Substring(col, 1).ToLower());
        //            if (Convert.ToChar(sortedList[row].Substring(col, 1).ToLower()) > Convert.ToChar(sortedList[row + 1].Substring(col, 1).ToLower()))
        //            {
        //                return "NO";
        //            }
        //        }
        //    }
        //    return "YES";
        //}

        [Fact]
        public void gridChallenge_Test() 
        {         
            var grid = new List<string>() 
            {
                "sur", //rsu reg
                "eyy", //eyy syx
                "gxy", //gxy uyy
            };

            var result = gridChallenge(grid);
            Assert.Equal("NO", result);
        }
    }
}

//3

//    3

//    abc

//    lmp

//    qrt

//    3

//    mpxz

//    abcd

//    wlmf

//    4

//    abc

//    hjk

//    mpq

//    rtv
//1

//    5

//    eabcd

//    fghij

//    olkmn

//    trpqs

//    xywuv

//6
//3
//ttt
//zzz
//zzz
//3
//rpb
//hot
//qra
//7
//zzzzzwz
//zzzzzzw
//wzzzzzz
//zzwzzzz
//zzyzzzz
//zzzzyzz
//zzzzzyz
//5
//sysjf
//vubdh
//hralk
//dntwp
//tjidx
//8
//plkcarul
//yqkpzifl
//bdahextl
//fjadsmlo
//msokhmxd
//bisjycrw
//emqdadoz
//bvozaplr
//5
//zxxzx
//zxxzx
//zxzxx
//xzzxx
//zzxxx

//var grid = new List<string>()
//            {
//                "sysjf",
//                "vubdh",
//                "hralk",
//                "dntwp",
//                "tjidx",
//            };