using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pica_Y_Fija
{
    class Jugar
    {
        public static int a = 0, b = 0, c =  0, d = 0, e = 0, f = 0;

        public int Aleatorio()
        {
            int i = 0, x;
            Random random = new Random();
            int sw = 0, num = 0;

            while (sw == 0){
                num = random.Next(100000, 999999);
                x = num;
                for (i = 1; i <= 6; i++)
                {
                    if (i == 1)
                    {
                        f = (x % 10);
                    }
                    if (i == 2)
                    {
                        e = (x % 10);
                    }
                    if (i == 3)
                    {
                        d = (x % 10);
                    }
                    if (i == 4)
                    {
                        c = (x % 10);
                    }
                    if (i == 5)
                    {
                        b = (x % 10);
                    }
                    if (i == 6)
                    {
                        a = (x);
                    }
                    x = x / 10;
                }
                sw = Comparar(); 
            }
            return num;
        }

        public int Comparar()
        {
            if (a != b && a != c && a != d && a != e && a != f)
            {
                if (b != c && b != d && b != e && b != f)
                {
                    if (c != d && c != e && c != f)
                    {
                        if (d != e && d != f && e != f)
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }

    }
}
