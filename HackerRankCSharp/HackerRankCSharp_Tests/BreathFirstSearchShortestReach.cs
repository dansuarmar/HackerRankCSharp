using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class BreathFirstSearchShortestReach
    {
        public static List<int> bfs(int n, int m, List<List<int>> edges, int s)
        {
            int[] leverlArr = new int[n + 1];
            leverlArr[0] = -1;
            leverlArr[s] = -1;
            List<List<int>> graph = new();
            for (int i = 0; i < n + 1; i++) 
                graph.Add(new());
            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            Queue<int> queue = new();
            queue.Enqueue(s);
            int level = 0;
            while (queue.Count > 0)
            {
                level++;
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    int cur = queue.Dequeue();
                    foreach (var next in graph[cur])
                    {
                        if (leverlArr[next] == 0)
                        {
                            leverlArr[next] = level;
                            queue.Enqueue(next);
                        }
                    }
                }
            }
            List<int> answer = new();
            for (int i = 1; i < n + 1; i++)
            {
                if (i == s) continue;
                if (leverlArr[i] != 0) answer.Add(leverlArr[i] * 6);
                else answer.Add(-1);
            }
            return answer;
        }
    }
}
