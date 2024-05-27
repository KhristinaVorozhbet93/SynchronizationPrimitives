namespace SynchronizationPrimitives
{
    public class SpinLockPrimitive
    {
        private volatile int _lock = 0;

        public void Enter()
        {
            while (true)
            {
                if (Interlocked.CompareExchange(ref _lock, 1, 0) == 0)
                {
                    return;
                }

                Thread.Sleep(1);
            }
        }

        public void Exit()
        {

            Interlocked.Exchange(ref _lock, 0);
        }
    }
}

