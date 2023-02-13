using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class NoPrefixSet
    {
        [Fact]
        public void noPrefix_Test() 
        {
            var list = new List<string>() 
            {
                "defgab",
                "abcde",
                "aabcde",
                "aab",
                "cedaaa",
                "bbbbbbbbbb",
                "jabjjjad",
            };

            var list2 = test.Split("\r\n");
            noPrefix(list);           
        }

        //public static void noPrefix(List<string> words)
        //{
        //    var result = new List<string>();
        //    for (int i = 0; i < words.Count(); i++)
        //    {
        //        var word = words[i];
        //        var wordRemoved = words.Where(m => m != word);
        //        foreach (var test in wordRemoved)
        //        {
        //            if (word.StartsWith(test))
        //            {
        //                result.Add("BAD SET");   
        //                if(word.IndexOf(test) > i)
        //                    result.Add(test);
        //                else
        //                    result.Add(word);
        //                break;
        //            }
        //        }
        //        if (result.Count > 0)
        //            break;
        //    }
        //    if(result.Count == 0) 
        //        result.Add("GOOD SET");

        //    foreach(var resp in result)
        //        Console.WriteLine(resp);
        //}

        string test = "hgiiccfchbeadgebc\r\nbiiga\r\nedchgb\r\nccfdbeajaeid\r\nijgbeecjbj\r\nbcfbbacfbfcfbhcbfjafibfhffac\r\nebechbfhfcijcjbcehbgbdgbh\r\nijbfifdbfifaidje\r\nacgffegiihcddcdfjhhgadfjb\r\nggbdfdhaffhghbdh\r\ndcjaichjejgheiaie\r\nd\r\njeedfch\r\nahabicdffbedcbdeceed\r\nfehgdfhdiffhegafaaaiijceijdgbb\r\nbeieebbjdgdhfjhj\r\nehg\r\nfdhiibhcbecddgijdb\r\njgcgafgjjbg\r\nc\r\nfiedahb\r\nbhfhjgcdbjdcjjhaebejaecdheh\r\ngbfbbhdaecdjaebadcggbhbchfjg\r\njdjejjg\r\ndbeedfdjaghbhgdhcedcj\r\ndecjacchhaciafafdgha\r\na\r\nhcfibighgfggefghjh\r\nccgcgjgaghj\r\nbfhjgehecgjchcgj\r\nbjbhcjcbbhf\r\ndaheaggjgfdcjehidfaedjfccdafg\r\nefejicdecgfieef\r\nciidfbibegfca\r\njfhcdhbagchjdadcfahdii\r\ni\r\nabjfjgaghbc\r\nbddeejeeedjdcfcjcieceieaei\r\ncijdgbddbceheaeececeeiebafgi\r\nhaejgebjfcfgjfifhihdbddbacefd\r\nbhhjbhchdiffb\r\njbbdhcbgdefifhafhf\r\najhdeahcjjfie\r\nidjajdjaebfhhaacecb\r\nbhiehhcggjai\r\nbjjfjhiice\r\naif\r\ngbbfjedbhhhjfegeeieig\r\nfefdhdaiadefifjhedaieaefc\r\nhgaejbhdebaacbgbgfbbcad\r\nheghcb\r\neggadagajjgjgaihjdigihfhfbijbh\r\njadeehcciedcbjhdeca\r\nghgbhhjjgghgie\r\nibhihfaeeihdffjgddcj\r\nhiedaegjcdai\r\nbjcdcafgfjdejgiafdhfed\r\nfgdgjaihdjaeefejbbijdbfabeie\r\naeefgiehgjbfgidcedjhfdaaeigj\r\nbhbiaeihhdafgaciecb\r\nigicjdajjdegbceibgebedghihihh\r\nbaeeeehcbffd\r\najfbfhhecgaghgfdadbfbb\r\nahgaccehbgajcdfjihicihhc\r\nbbjhih\r\na\r\ncdfcdejacaicgibghgddd\r\nafeffehfcfiefhcagg\r\najhebffeh\r\ne\r\nhhahehjfgcj\r\nageaccdcbbcfidjfc\r\ngfcjahbbhcbggadcaebae\r\ngi\r\nedheggceegiedghhdfgabgcd\r\nhejdjjbfacggdccgahiai\r\nffgeiadgjfgecdbaebagij\r\ndgaiahge\r\nhdbaifh\r\ngbhccajcdebcig\r\nejdcbbeiiebjcagfhjfdahbif\r\ng\r\nededbjaaigdhb\r\nahhhcibdjhidbgefggdjebfcf\r\nbdigjaehfchebiedajcjdh\r\nfjehjgbdbaiifi\r\nfbgigbdcbcgffdicfcidfdafghajc\r\nccajeeijhhb\r\ngaaagfacgiddfahejhbgdfcfbfeedh\r\ngdajaigfbjcdegeidgaccjfi\r\nfghechfchjbaebcghfcfbdicgaic\r\ncfhigaciaehacdjhfcgajgbhhgj\r\nedhjdbdjccbfihiaddij\r\ncbbhagjbcadegicgifgghai\r\nhgdcdhieji\r\nfbifgbhdhagch\r\ncbgcdjea\r\ndggjafcajhbbbaja\r\nbejihed\r\neeahhcggaaidifdigcfjbficcfhjj";

        public static void noPrefix(List<string> words)
        {
            PrefixTree pt = new PrefixTree();

            foreach (string word in words)
            {
                if (!pt.Add(word))
                {
                    Console.WriteLine("BAD SET");
                    Console.WriteLine(word);
                    return;
                }
            }

            Console.WriteLine("GOOD SET");
        }
    }

    class PrefixTree
    {

        private Dictionary<char, PrefixTree> subTrees = new Dictionary<char, PrefixTree>();

        private bool endOfWord = false;

        public bool Add(string word)
        {
            bool result = false;

            PrefixTree pt = this;

            foreach (char c in word)
            {
                //If the key exists, then just catch the error to skip adding
                try
                {
                    pt.subTrees.Add(c, new PrefixTree());
                }
                catch (ArgumentException ex)
                {

                }
                pt = pt.subTrees[c];

                if (pt.endOfWord)
                {
                    return false;
                }
            }

            pt.endOfWord = true;

            // verify if prefix or not
            return result = pt.subTrees.Count == 0 ? true : false;
        }
    } 
}
