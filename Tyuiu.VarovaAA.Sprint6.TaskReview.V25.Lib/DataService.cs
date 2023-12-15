using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VarovaAA.Sprint6.TaskReview.V25.Lib
{
    public class DataService
    {
        public int[,] GetRandomMatrix(int n, int m, int n1, int n2, int x)
        {
            Random random = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 != 0)
                    {
                        array[i, j] = x;
                    }
                    else
                    {
                        array[i, j] = random.Next(n1, n2 + 1);
                    }
                }
            }
            return array;
        }

        public int GetMatrix(int[,] array, int r, int k, int l)
        {
            int sum = 0;
            for (int i = k; i <= l; i++)
            {
                if (array[r, i] % 2 != 0)
                {
                    sum += array[r, i];
                }
            }
            if (k < 0 || l < k || r < 0 || r >= array.GetLength(0))
            {
                throw new ArgumentException("Некорректно введены значения");
            }
            return sum;
        }
    }
}