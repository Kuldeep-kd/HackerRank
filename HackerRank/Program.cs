using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
        }

        static void plusMinus(int[] arr)
        {
            double d1, d2, d3;
            d1 = d2 = d3 = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                    d1++;
                else if (i < 0)
                    d2++;
                else if(i==0)
                    d3++;
            }
            int x = arr.Length;
            Console.Write("{0:###.#######} \n{1:###.#######} \n{2:###.#######}",(d1/x), d2/x, d3/x);
            
            

        }
    }
}
