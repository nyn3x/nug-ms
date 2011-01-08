// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbContext.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3.Infrastructure
{
    using NHibernate;

    /// <summary>
    /// The db context.
    /// </summary>
    public static class DbContext
    {
        #region Fields

        /// <summary>
        /// The _session factory.
        /// </summary>
        private static ISessionFactory _sessionFactory;

        #endregion

        #region Properties

        /// <summary>
        /// Gets SessionFactory.
        /// </summary>
        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }

        #endregion

        /// <summary>
        /// The init.
        /// </summary>
        /// <param name="sessionFactory">
        /// The session factory.
        /// </param>
        public static void Init(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }
    }
}