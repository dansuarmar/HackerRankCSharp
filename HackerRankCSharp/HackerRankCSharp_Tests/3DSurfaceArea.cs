using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class _3DSurfaceArea
    {
        public static int surfaceArea(List<List<int>> A)
        {
            int area = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Count; j++)
                {
                    area += A[i][j] * 4 + 2;
                    if (i > 0)
                        area -= Math.Min(A[i - 1][j], A[i][j]) * 2;
                    
                    if (j > 0)
                        area -= Math.Min(A[i][j - 1], A[i][j]) * 2;
                }
            }
            return area;
        }
    }
}
