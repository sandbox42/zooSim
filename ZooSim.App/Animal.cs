using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSim
{
    public abstract class Animal
    {

        float _newhealth = 0;
        float _previousHealth = 0;

        public float Health { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Mortality { get; set; }

        public Animal(int mortality)
        {
            Mortality = mortality;
        }

        public virtual void FeedMe(int modifier)
        {
            if (Health < 100)
            {
                _newhealth = Health + (Health * modifier / 100);


                // assign derived health rating which must not exceed 100 percent
                Health = _newhealth > 100 ? 100 : _newhealth;
            }
        }
        public virtual void Retard(int modifier)
        {
            if (Health > 0)
            {
                // recalculate health
                _newhealth = Health - (Health * modifier / 100);

                
                // assign derived health rating - zero is the minimum
                Health = _newhealth < 0 ? 0 : _newhealth;
            }
        }

        public virtual bool IsAlive ()
        {
            return  Health < Mortality ? false : true;
        }

    }
}
