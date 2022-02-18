using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        static int i = 0;

        public static int ride(int k, int[] g, int r)
        {
            i = 0;
            int sk = 0;
            int n = 0;

            if (!g.Any())
            {
                return n;
            }

            for (int j = 1; j <= r; j++)
            {
                sk += ride2(k, g);
            }

            return sk;
        }

        public static int ride2(int k, int[] g)
        {
            int kekka = 0;
            Boolean flg = true;
            while (flg)
            {
                Console.Write(i);
                if (kekka + g[i] > k)
                {
                    flg = false;
                }
                else
                {
                    kekka += g[i];
                    if (g.Length == 1)
                    {
                        flg = false;
                    }
                    i = (i + 1) % g.Length;
                }
            }

            return kekka;
        }
    }
}
