// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Default.aspx.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The _ default.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3
{
    using System;
    using System.Web.UI;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Criterion;
    using Entities;

    /// <summary>
    /// The _ default.
    /// </summary>
    public partial class _Default : Page
    {
        #region Fields

        /// <summary>
        /// The _session factory.
        /// </summary>
        private ISessionFactory _sessionFactory;

        #endregion

        /// <summary>
        /// The on pre render.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            using (var session = _sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var customers = session.CreateCriteria<Customer>()
                    .Add(Restrictions.Eq("Id", "ALFKI"))
                    .List<Customer>();

                customerList.DataSource = customers;
                customerList.DataBind();

                tx.Commit();
            }
        }

        /// <summary>
        /// The page_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof (Customer).Assembly);

            _sessionFactory = configuration.BuildSessionFactory();
        }
    }
}