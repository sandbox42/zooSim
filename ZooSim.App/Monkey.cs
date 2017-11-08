namespace ZooSim
{
    public class Monkey : Animal
    {
        private const float MortalityPercentage = 30;
        public Monkey() : base(MortalityPercentage)
        {
            Type = "Monkey";
            Health = 100f;
        }

    }
}
