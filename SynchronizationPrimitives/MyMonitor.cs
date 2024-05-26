namespace SynchronizationPrimitives
{
    public class MyMonitor : ILock
    {
        private object _syncObject = new();
        public void Enter()
        {
            Monitor.Enter(_syncObject);
        }

        public void Exit()
        {
            Monitor.Exit(_syncObject);
        }
    }
}
