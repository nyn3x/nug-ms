namespace IOC_Sample.ServiceWatch
{
    using Notification;

    public class ServiceWatcher : IServiceWatcher
    {
        #region Fields

        private readonly INotifier _notifier;

        #endregion

        #region Constructors

        public ServiceWatcher(INotifier notifier)
        {
            _notifier = notifier;
        }

        #endregion

        #region IServiceWatcher Members

        public void StartWatching()
        {
            if (GetServiceHealth() == false)
                _notifier.Notify();
        }

        public void StopWatching()
        {
        }

        #endregion

        private bool GetServiceHealth()
        {
            return false;
        }
    }
}