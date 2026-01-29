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
            if (!flag) return -1;
            if (n <= 1) return n;
            return funFibonacci(n - 1, true) + funFibonacci(n - 2, true);
        }
    }
}
