using System;

namespace ZooSim.App
{
    public class Elephant : Animal
    {
        private const float MortalityPercentage = 70;
        float _newhealth = 0f;
        float _previousHealth = 100f;
        public Elephant() : base(MortalityPercentage)
        {
            Type = "Elephant";
            Health = 100f;
        }
        
        public override void FeedMe(int modifier)
        {
            if (Health < 100f)
            {
                _previousHealth = Health;

                //calculate health after feed
                _newhealth = Health + (Health * modifier / 100f);

                // assign derived health rating which must not exceed 100 percent
                Health = Math.Min(_newhealth, 100f);


            }
        }
        public override void Retard(int modifier)
        {
            if (Health > 0)
            {
                _previousHealth = Health;

                // recalculate health
                _newhealth = Health - (Health * modifier / 100f);

                // assign derived health rating - zero is the minimum
                Health = Math.Max(_newhealth, 0f);


            }
        }

        public override bool IsAlive()
        {
            return Health < Mortality && _previousHealth < Mortality ? false : true;
        }

    }
}
