using System;

namespace Transpose_Matrix
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      /*
       Input: matrix = [[1,2,3],[4,5,6]]
        Output: [[1,4],[2,5],[3,6]] 

      Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
      Output: [[1,4,7],[2,5,8],[3,6,9]]
       */
    }
  }

  public class Solution
  {
    public int[][] Transpose(int[][] matrix)
    {
      int m = matrix.Length;
      int n = matrix[0].Length;
      // transpose is [r][c] cells value swap with [c][r] value.
      // we create a new array from r*c to c*r
      var newmatrix = new int[n][];
      for (int j = 0; j < n; j++)
      {
        newmatrix[j] = new int[m];
        for (int i = 0; i < m; i++)
        {
          newmatrix[j][i] = matrix[i][j]; // set the newmatrix[r][c] with matrix[c][r]
        }
      }

      return newmatrix;
    }
  }
}
