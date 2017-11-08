namespace ZooSim.Domain
{
    public class Giraffe : Animal
    {
        private const float MortalityPercentage = 50f;
        public Giraffe() : base(MortalityPercentage)
        {
            Type = "Giraffe";
            Health = 100f;
        }

    }
}
