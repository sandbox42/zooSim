namespace ZooSim.Domain
{
    interface IAnimal
    {
        void FeedMe(int modifier);
        void Retard(int modifier);
        bool IsAlive();

    }
}
