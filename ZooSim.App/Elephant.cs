using System;

namespace ZooSim.App
{
    public class Elephant : Animal
    {
        private const int MortalityPercentage = 70;
        float _newhealth = 0;
        float _previousHealth = 0;
        public Elephant() : base(MortalityPercentage)
        {
        }
        


        //public override void FeedMe(int modifier)
        //{
        //    base.FeedMe(modifier);
        //    base.IsAlive();

        //}


        //public override void Retard(int modifier)
        //{
        //    base.Retard(modifier);
        //    base.IsAlive();

        //}

        public override void FeedMe(int modifier)
        {
            if (Health < 100)
            {
                //calculate health after feed
                _newhealth = Health + (Health * modifier / 100);

                // assign derived health rating which must not exceed 100 percent
                Health = _newhealth > 100 ? 100 : _newhealth;

                _previousHealth = Health;
            }
        }
        public override void Retard(int modifier)
        {
            if (Health > 0)
            {
                // recalculate health
                _newhealth = Health - (Health * modifier / 100);

                // assign derived health rating - zero is the minimum
                Health = _newhealth < 0 ? 0 : _newhealth;

                _previousHealth = Health;
            }
        }

        public override bool IsAlive()
        {
            return Health < Mortality && _previousHealth < Mortality ? false : true;
        }

    }
}
