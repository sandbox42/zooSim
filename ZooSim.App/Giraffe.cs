namespace ZooSim
{
    public class Giraffe : Animal
    {
        private const float MortalityPercentage = 50;
        public Giraffe() : base(MortalityPercentage)
        {
            Type = "Giraffe";
            Health = 100f;
        }

    }
}
