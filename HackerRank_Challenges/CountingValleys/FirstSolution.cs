using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class FirstSolution
    {
        public int countingValleys(int n, string s)
        {
            int seaLevel = 0, valley = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    seaLevel += 1;
                    if (seaLevel == 2)
                    {
                        valley += 1;
                        seaLevel = 0;
                    }
                }
                else
                    seaLevel = 0;
            }
            return valley;
        }
    }
}
