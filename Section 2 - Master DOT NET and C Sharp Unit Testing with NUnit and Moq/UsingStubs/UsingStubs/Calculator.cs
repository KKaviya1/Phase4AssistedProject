﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStubs
{

    public interface ICalculator
    {
        int add(int x, int y);
        int addStrings(string x, string y);
    }


    public class Calculator : ICalculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int addStrings(string x, string y)
        {
            int a = 0, b = 0;
            Int32.TryParse(x, out a);
            Int32.TryParse(y, out b);

            if (a == 0 || b == 0)
                throw new InvalidOperationException("String values are not valid integers");

            return a + b;
        }
    }

    public class FakeCalculator : ICalculator
    {
        public int add(int x, int y)
        {
            return 10;
        }

        public int addStrings(string x, string y)
        {
            return 10;
        }
    }
}


