using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSim
{
    public class Monkey : Animal
    {
        private const int MortalityPercentage = 30;
        public Monkey() : base(MortalityPercentage)
        {
        }

    }
}
