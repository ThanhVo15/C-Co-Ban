using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19___Class
{
    public class ClassTestParams
    {
        public int Sum(params int[] arr)
        {
            int s = 0;

            foreach (int i in arr)
                s+= i;
            return s;
        }
    }
}
