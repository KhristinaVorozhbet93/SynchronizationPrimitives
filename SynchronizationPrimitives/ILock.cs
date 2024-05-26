namespace SynchronizationPrimitives
{
    public interface ILock
    {
        void Enter();
        void Exit();
    }
}
