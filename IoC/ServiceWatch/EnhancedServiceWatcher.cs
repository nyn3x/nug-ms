namespace IOC_Sample.ServiceWatch
{
    using Notification;

    internal class EnhancedServiceWatcher : IServiceWatcher
    {
        #region Fields

        private readonly INotifier[] _notifier;

        #endregion

        #region Constructors

        public EnhancedServiceWatcher(INotifier[] notifier)
        {
            _notifier = notifier;
        }

        #endregion

        #region IServiceWatcher Members

        public void StartWatching()
        {
            if (GetServiceHealth() == false)
                foreach (var myNotifier in _notifier)
                {
                    myNotifier.Notify();
                }
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