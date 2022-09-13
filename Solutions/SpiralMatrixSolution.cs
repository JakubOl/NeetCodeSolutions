using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class SpiralMatrixSolution
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0;
            int right = matrix[0].Length;
            var top = 0;
            var bottom = matrix.Length;

            List<int> output = new List<int>();

            while (left < right && top < bottom)
            {
                for (int i = left; i < right; i++)
                {
                    output.Add(matrix[top][i]);
                }
                top = top + 1;

                for(int j = top; j < bottom; j++)
                {
                    output.Add(matrix[j][right - 1]);
                }
                right = right - 1;

                if (!(left < right && top < bottom)) break;

                for (int l = right - 1; l > left - 1; l--)
                {
                    output.Add(matrix[bottom - 1][l]);
                }
                bottom = bottom - 1;

                for (int k = bottom - 1; k > top - 1; k--)
                {
                    output.Add(matrix[k][left]);
                }
                left = left + 1;
            }
            return output;
        }
    }
}
