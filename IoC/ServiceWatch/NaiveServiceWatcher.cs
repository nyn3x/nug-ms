namespace IOC_Sample.ServiceWatch
{
    using Notification;

    public class NaiveServiceWatcher
    {
        public void StartWatching()
        {
            if (GetServiceHealth() == false)
            {
                INotifier notifier = new EmailNotifier();
                notifier.Notify();
            }
        }


        public void StopWatching()
        {
        }

        private bool GetServiceHealth()
        {
            return false;
        }
    }
}