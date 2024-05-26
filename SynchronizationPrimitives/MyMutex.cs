namespace SynchronizationPrimitives
{
    public class MyMutex : ILock
    {
        private Mutex _mutex = new Mutex(false, "MyMutex");
        public void Enter()
        {          
            _mutex.WaitOne();
        }
        public void Exit()
        {
            _mutex.ReleaseMutex();
        }
    }
}
