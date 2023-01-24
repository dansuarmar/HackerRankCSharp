using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class HackerRank_ReverseMatrix
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int size = matrix.Count();
            for (int row = 0; row < size / 2; row++)
            {
                for (int col = 0; col < size / 2; col++)
                {
                    var thisLevel = new List<int>();
                    thisLevel.Add(matrix[row][col]); //UpLeft Corner
                    thisLevel.Add(matrix[row][size - 1 - col]); //UpRight Corner
                    thisLevel.Add(matrix[size - 1 - row][col]); //DownLeft Corner
                    thisLevel.Add(matrix[size - 1 - row][size - 1 - col]); //DownRight Corner
                    sum += thisLevel.Max();
                }
            }
            return sum;
        }

        //Math.Max(
        //matrix[row][col], Math.Max(
        //    matrix[row][size - 1 - col], Math.Max(
        //        matrix[size - 1 - row][col], matrix[size - 1 - row][size - 1 - col]
        //)));

        [Fact]
        public void SumCorner_Test()
        {
            List<List<int>> matrix = new()
            {
                new List<int>() { 112, 42, 83, 119 },
                new List<int>() { 56, 125, 56, 49 },
                new List<int>() { 15, 78, 101, 43 },
                new List<int>() { 62, 98, 114, 108 },
            };

            var result = flippingMatrix(matrix);
            Assert.Equal(414, result);
        }
    }
}
