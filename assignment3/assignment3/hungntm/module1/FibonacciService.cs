using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.hungntm.module1
{
    public class FibonacciService : IFibonacci
    {
        public int funFibonacci(int n, bool flag)
        {
            if (flag) return -1;
            if (n <= 1) return n;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
