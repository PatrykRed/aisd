using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "babab";
            string b = "abaabbaaa";
            int[,] lcs = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    { 
                        lcs[i + 1, j + 1] = lcs[i, j] + 1;
                    }
                    else
                    {
                        lcs[i + 1, j + 1] = Math.Max(lcs[i + 1, j], lcs[i, j + 1]);
                    }
                }
            }

            for (int i = 0; i < lcs.GetLength(0); i++)
            {
                for (int j = 0; j < lcs.GetLength(1); j++)
                {
                    Console.Write("{0} ", lcs[i, j]);
                }
                Console.WriteLine();
            }

            int n = a.Length;
            int m = b.Length;
            while (lcs[n, m] != 0)            // w lewo
            {
                if (lcs[n - 1, m] == lcs[n, m])
                {
                    n--;
                }
                else if (lcs[n, m - 1] == lcs[n, m])
                    m--;
                else
                {
                    Console.Write(a[n - 1] + " ");
                    n--;
                    m--;
                }
            }

          /*while (lcs[n, m] != 0) // do gory
            {
                if (lcs[n, m - 1] == lcs[n, m])
                {
                    m--;
                }
                else if (lcs[n - 1, m] == lcs[n, m])
                    n--;
                else
                {
                    Console.Write(a[n - 1] + " ");
                    n--;
                    m--;
                }
            }*/

            Console.ReadKey(true);
        }
    }
}
