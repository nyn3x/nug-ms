namespace IOC_Sample.Notification
{
    using System;

    public class SmSNotifier : INotifier
    {
        #region INotifier Members

        public void Notify()
        {
            Console.WriteLine("This is a sms notification.");
        }

        #endregion
    }
}