using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSim
{
    interface IAnimal
    {
        void FeedMe(int modifier);
        void Retard(int modifier);
        bool IsAlive();

    }
}
