namespace IOC_Sample.Notification
{
    using System;

    public class EmailNotifier : INotifier
    {
        #region Constructors

        public EmailNotifier()
        {
            MailServer = "none";
        }

        #endregion

        //public EmailNotifier(string MailServer)
        //{
        //    this.MailServer = MailServer;
        //}

        #region Properties

        public string MailServer { get; set; }

        #endregion

        #region INotifier Members

        public void Notify()
        {
            Console.WriteLine(string.Format("This is an email notification using {0}.", MailServer));
        }

        #endregion
    }
}