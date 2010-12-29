namespace NHibernate3
{
    using System;
    using System.Web.UI;
    using Entities;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Criterion;

    public partial class _Default : Page
    {
        #region Fields

        private ISessionFactory _sessionFactory;

        #endregion

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            using (var session = _sessionFactory.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                var customers = session.CreateCriteria<Customer>()
                    .Add(Expression.Eq("Id", "ALFKI"))
                    .List<Customer>();

                customerList.DataSource = customers;
                customerList.DataBind();

                tx.Commit();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof (Customer).Assembly);

            _sessionFactory = configuration.BuildSessionFactory();

        }
    }
}