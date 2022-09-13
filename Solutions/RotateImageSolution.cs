using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class RotateImageSolution
    {
        public static void Rotate(int[][] matrix)
        {
            var l = 0;
            var r = matrix.Length - 1;

            while (l < r)
            {
                for(int i = 0; i < r - l; i++)
                {
                    var top = l;
                    var bottom = r; 

                    var topLeft = matrix[top][l + i];

                    matrix[top][l + i] = matrix[bottom - i][l];

                    matrix[bottom - i][l] = matrix[bottom][r - i];

                    matrix[bottom][r - i] = matrix[top + i][r];

                    matrix[top + i][r] = topLeft;
                }
                l++;
                r--;
            }

            for (int n = 0; n < matrix.Length; n++)
            {

                // Print the row number
                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < matrix[n].Length; k++)
                {
                    // Print the elements in the row
                    System.Console.Write("{0} ", matrix[n][k]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
