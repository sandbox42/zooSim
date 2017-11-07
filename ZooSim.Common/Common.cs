using System;

namespace ZooSim.Common
{
    public enum HealthAction
    {
        Boost,
        Reduce
    }

    public static class RandomNumber
    {
        private static Random rnd = new Random();

        public static int GetRandom(HealthAction healthAction)
        {
            switch (healthAction)
            {
                case HealthAction.Boost:
                    return rnd.Next(10, 25);

                case HealthAction.Reduce:
                    return rnd.Next(0, 20);

                default:
                    return 0;
            }

        }
    }
}
