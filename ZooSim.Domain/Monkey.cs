namespace ZooSim.Domain
{
    public class Monkey : Animal
    {
        private const float MortalityPercentage = 30f;
        public Monkey() : base(MortalityPercentage)
        {
            Type = "Monkey";
            Health = 100f;
        }

    }
}
