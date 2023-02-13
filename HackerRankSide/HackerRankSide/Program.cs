using System.Collections;
namespace HackerRankSide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Stack st = new Stack();
            st.Push(1);
            st.Push(1.1);
            st.Push('c');
            st.Push("Hello");

            foreach(var i in st) 
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}