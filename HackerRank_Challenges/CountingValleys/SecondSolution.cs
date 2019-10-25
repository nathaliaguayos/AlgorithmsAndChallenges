using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class SecondSolution
    {
        public int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            int valleys = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (++seaLevel == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    seaLevel--;
                }
            }

            return valleys;
        }
    }
}
