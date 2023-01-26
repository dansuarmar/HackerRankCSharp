using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class QueueUsingTwoStacks
    {
        //static void Main(String[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<int>> arr = new List<List<int>>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //    }

        //    // foreach(var top in arr)
        //    // {
        //    //     foreach(var item in top)
        //    //         textWriter.WriteLine(item.ToString());
        //    // }

        //    var result = new List<int>() { 14, 14 };
        //    foreach (var item in result)
        //    {
        //        textWriter.WriteLine(result.ToString());
        //    }

        //    textWriter.Flush();
        //    textWriter.Close();
        //}

        [Fact]
        public void ProcessQueue_Test() 
        {
            var instructions = new List<List<int>>() 
            {
                new List<int>() { 1, 42, },
                new List<int>() { 2, },
                new List<int>() { 1, 14, },
                new List<int>() { 3, },
                new List<int>() { 1, 28, },
                new List<int>() { 3, },
                new List<int>() { 1, 60, },
                new List<int>() { 1, 78, },
                new List<int>() { 2, },
                new List<int>() { 2, },
            };

            var result = ProcessQueue(instructions);
            Assert.Equal(2, result.Count);
        }

        public List<string> ProcessQueue(List<List<int>> instructions) 
        {
            var regreso =  new List<string>();
            //var queue = new StackQueue();
            var queue = new Queue<int>();
            foreach(var item in instructions) 
            {
                switch(item[0])
                {
                    case 1:
                        queue.Enqueue(item[1]);
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        regreso.Add(queue.Peek().ToString());
                        break;
                }
            }
            return regreso;
        }
    }

    public class StackQueue
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();   

        public void Enqueue(int value) 
        {
            if (stack2.Count > 0)
                MoveBackToStack1();

            stack1.Push(value);
        }

        private void MoveAllToStack2() 
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        private void MoveBackToStack1() 
        {
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public int Peek()
        {
            if (stack2.Count == 0)
                MoveAllToStack2();

            return stack2.Peek();
        }

        public int Dequeue() 
        {
            if (stack2.Count == 0)
                MoveAllToStack2();

            return stack2.Pop();
        }
    }
}
