using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class EnemyUtils
    {
        public static double calculateScaling(double input, int level)
        {
            input = Math.Round(input * (1 + 0.1 * level));
            return input;
        }
    }
}
