using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.hoanglt.module1
{
    public class FibonacciRecursive : IFibonacci
    {
        public int Fun(int n, bool flag)
        {
            if (!flag)
                return -1;

            return Fib(n);
        }

        private int Fib(int n)
        {
            if (n <= 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
