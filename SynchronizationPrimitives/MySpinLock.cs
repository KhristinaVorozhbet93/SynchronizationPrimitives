namespace SynchronizationPrimitives
{
    public class MySpinLock : ILock
    {
        private SpinLock _lock;
        public void Enter()
        {
            bool _lockToken = false;
            _lock.Enter(ref _lockToken);
        }

        public void Exit()
        {
            _lock.Exit();
        }
    }
}
