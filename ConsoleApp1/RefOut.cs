using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class RefOut
    {
        int a=0;
        int b=0;
        public void Squere(ref int a, ref int b)
        {
            a = 3;
            b = 5;
        }

        public void Squere (int a, int b, out int squre)
        {
            squre = a * b;
        }
    }
}
