using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms_FibonacciNumbers
{
    class Fibo
    {
        public long Fibo1(int N)
        {
            if (N == 1 || N == 2)
                return 1;
            return Fibo1(N - 1) + Fibo1(N - 2);
        }

        public long Fibo2(int N)
        {
            long f1 = 1;
            long f2 = 1;
            long f3=0;
            for (int j=1;j<N;j++)
            {
                if (j < 3)
                {
                    f1 = 1;
                    f2 = 1;
                }

                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            if (N < 3)
                return 1;
           return f3;
        }



    }
}
