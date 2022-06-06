using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Comparers
{
    public class DefaultComparer : IComparer<int>
    {
        public int Compare(int first, int second)
        {
            if (first > second)
            {
                return 1;
            }
            else if (first == second)
            {
                return 0;
            }

            return -1;
        }
    }
}
