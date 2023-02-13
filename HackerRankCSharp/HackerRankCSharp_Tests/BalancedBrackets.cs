using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class BalancedBrackets
    {
        [Fact]
        public static void isBalanced_Tests()
        {
            //var string1 = "{[()]}";
            var string1 = "[]][{]{(({{)[})(}[[))}{}){[{]}{})()[{}]{{]]]){{}){({(}](({[{[{)]{)}}}({[)}}([{{]]({{";
            var string2 = "{[(])}";
            //var string3 = "{{[[(())]]}}";
            var string3 = ")}{){(]{)([)}{)]())[(})[]]))({[[[)}[((]](])][({[]())";

            Assert.Equal("NO", isBalanced(string1));
            Assert.Equal("NO", isBalanced(string2));
            Assert.Equal("NO", isBalanced(string3));
        }

        public static string isBalanced(string s)
        {
            var openings = new[] { '[', '{', '(' };

            var stack = new Stack<char>();

            foreach (var c in s.ToCharArray())
            {
                switch (c)
                {
                    case var a when openings.Contains(a):
                        stack.Push(c);
                        break;
                    case var a when a == ']':
                        if (stack.Count() == 0 || stack.Peek() != '[')
                            return "NO";
                        else
                            stack.Pop();
                        break;
                    case var a when a == ')':
                        if (stack.Count() == 0 || stack.Peek() != '(')
                            return "NO";
                        else
                            stack.Pop();
                        break;
                    case var a when a == '}':
                        if (stack.Count() == 0 || stack.Peek() != '{')
                            return "NO";
                        else
                            stack.Pop();
                        break;
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }

        //static bool TryPeek(Stack<char> stack, char value)
        //{
        //    value = default(char);

        //    if (stack.Count == 0) return false;

        //    value = stack.Peek();
        //    return true;
        //}

        //static string isBalanced(string s)
        //{
        //    var openings = new[] { '[', '{', '(' };

        //    var stack = new Stack<char>();

        //    foreach (var c in s.ToCharArray())
        //    {
        //        if (openings.Contains(c))
        //            stack.Push(c);

        //        else if (c == ']')
        //            if (!PeekNReturn(stack, out var c1) || c1 != '[')
        //                return "NO";
        //            else
        //                stack.Pop();

        //        else if (c == ')')
        //            if (!PeekNReturn(stack, out var c2) || c2 != '(')
        //                return "NO";
        //            else
        //                stack.Pop();

        //        else if (c == '}')
        //            if (!PeekNReturn(stack, out var c3) || c3 != '{')
        //                return "NO";
        //            else
        //                stack.Pop();
        //    }

        //    return stack.Count == 0 ? "YES" : "NO";
        //}

        //static bool PeekNReturn(Stack<char> stack, out char value)
        //{
        //    value = default(char);

        //    if (stack.Count == 0) return false;

        //    value = stack.Peek();
        //    return true;
        //}
    }
}
