namespace NHibernate3.Infrastructure
{
    using NHibernate;

    public static class DbContext
    {
        private static ISessionFactory _sessionFactory;

        public static void Init(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }
    }
}