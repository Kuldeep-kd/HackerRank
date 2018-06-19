using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            staircase(3);
            Console.ReadKey();
        }

        static void staircase(int n)
        {
            int i=1, j=1;
            string s="";
            while(i<=n)
            {
                j = n - i;
                while(j>=1)
                {
                    s += " ";
                    j--;
                }
                j = 1;
                while (j<=i)
                {
                    s += "*";
                    j++;
                }
                Console.WriteLine(s);
                s = "";
                i++;
            }
            
        }
    }
}
