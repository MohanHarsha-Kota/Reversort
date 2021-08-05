using System;
using System.Linq;
using static System.Console;

namespace Reversort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int total = Convert.ToInt32(ReadLine());

            for (int tot=1;tot<=total;tot++)
            {
                int cl = Convert.ToInt32(ReadLine());
                int[] cnumarr = ReadLine().Split(' ').Take(cl).Select(int.Parse).ToArray();
                int cost = 0;
                for (int i = 0; i < cl - 1; i++)
                {
                    int min = 999999;
                    for(int k = i; k < cl; k++)
                    {
                        if(cnumarr[k]<min)
                        {
                            min = cnumarr[k];
                        }
                    }
                    int indx = Array.FindIndex(cnumarr, x => x == min);

                    Array.Reverse(cnumarr, i, indx-i+1);
                    cost += (indx - i + 1);
                    
                }
                WriteLine("Case #{0}: {1}", tot, cost);
            }
        }
    }
}
