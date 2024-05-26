namespace SynchronizationPrimitives
{
    public class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            ILock locker = new MyMonitor();
            //ILock locker = new MyMutex();
            //ILock locker = new MySpinLock();

            
            object _syncObject = new();
            var task = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        try
                        {
                           locker.Enter();
                            total++;
                        }
                        finally
                        {
                            locker.Exit();
                        }
                    }
                });

            for (int i = 0; i < 1000000; i++)
            {
                try
                {
                    locker.Enter();
                    total++;
                }
                finally
                {
                    locker.Exit();
                }
            }

            task.Wait();

            Console.WriteLine(total);
        }
    }
}
