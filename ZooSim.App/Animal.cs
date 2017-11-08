
using System;

namespace ZooSim
{
    public abstract class Animal : IAnimal
    {

        float _newhealth = 0f;
        float _previousHealth = 0f;
        protected float Mortality = 0f;

        internal float Health { get; set; }
        internal string Name { get; set; }
        internal string Type { get; set; }
        
        public Animal(float mortality)
        {
            Mortality = mortality;
        }

        public virtual void FeedMe(int modifier)
        {
            if (Health < 100f)
            {
                _newhealth = Health + (Health * modifier / 100f);


                // assign derived health rating which must not exceed 100 percent
                Health = Math.Min(_newhealth, 100f);

            }
        }
        public virtual void Retard(int modifier)
        {
            if (Health > 0f)
            {
                // recalculate health
                _newhealth = Health - (Health * modifier / 100);

                // assign derived health rating - zero is the minimum
                Health = Math.Max(_newhealth, 0f);

            }
        }

        public virtual bool IsAlive ()
        {
            return  Health < Mortality ? false : true;
        }

    }
}
