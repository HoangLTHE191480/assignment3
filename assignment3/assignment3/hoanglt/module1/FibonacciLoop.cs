using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.hoanglt.module1
{
    internal class FibonacciLoop : IFibonacci
    {
        public int Fun(int n, bool flag)
        {
            if (flag)
                return -1;

            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
