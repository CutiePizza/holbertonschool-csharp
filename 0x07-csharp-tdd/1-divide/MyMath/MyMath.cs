using System;

namespace MyMath
{
    /// <summary>
    /// Class Matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide integers of a mtrix by a number
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns>A new matrix</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
           if (matrix == null)
                return (null);
           int[,] newMat = new int[matrix.GetLength(0),matrix.GetLength(1)];
           try 
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMat[i,j] = matrix[i,j] / num;
                    }
                }
            return (newMat);
            } catch (DivideByZeroException) 
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
        }
    }
}
