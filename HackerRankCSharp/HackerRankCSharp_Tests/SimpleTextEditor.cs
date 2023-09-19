using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class SimpleTextEditor
    {
        [Fact]
        public static void SimpleTextEditor_Test() 
        {
            var arr = new List<List<string>>() 
            {
                new List<string>() { "1", "ewcgpjfh" },
                new List<string>() { "1", "igqsbqyp" },
                new List<string>() { "1", "qsdliigcj" },
                new List<string>() { "4", },
                new List<string>() { "3", "15" },
                new List<string>() { "1", "iilmgp" },
                new List<string>() { "2", "8" },
                new List<string>() { "4", },
                new List<string>() { "2", "18" },
                new List<string>() { "1", "scwhors" },
            };

            var result = ProcessFunctions(arr);
            Assert.Equal("y", result[0]);
        }

        public static List<string> ProcessFunctions(List<List<string>> arr)
        {
            List<string> regreso = new();

            Stack<String> stack = new();
            StringBuilder builder = new();

            foreach (var item in arr)
            {
                switch (item[0]) 
                {
                    case "1": //append
                        stack.Push(builder.ToString());
                        builder.Append(item[1]);
                        break;
                    case "2": //delete last K chars
                        stack.Push(builder.ToString());
                        builder.Remove(builder.Length - Convert.ToInt32(item[1]), Convert.ToInt32(item[1]));
                        break;
                    case "3": //print kth character
                        //textWriter.WriteLine(builder[Convert.ToInt32(item[1]) - 1]);
                        regreso.Add(builder[Convert.ToInt32(item[1]) - 1].ToString());
                        break;
                    case "4": //undo
                        builder = new StringBuilder(stack.Pop());
                        break;
                }
            }

            return regreso;

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
