using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSim
{
    public class Giraffe : Animal
    {
        private const int MortalityPercentage = 50;
        public Giraffe() : base(MortalityPercentage)
        {
        }

    }
}
