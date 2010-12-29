namespace NHibernate3
{
    using System;
    using System.IO;
    using System.Web;
    using Entities;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using Infrastructure;
    using log4net.Config;

    public class Global : HttpApplication
    {

        /// <summary>
        /// The logger for this class and its instances.
        /// </summary>
        private static readonly log4net.ILog __LOGGER = log4net.LogManager.GetLogger(typeof(Global));
        
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            __LOGGER.Info("App is started!");

            var fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                              .ConnectionString(c => c
                                                         .Database("Northwind")
                                                         .Server("localhost")
                                                         .TrustedConnection()
                              )
                              .ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Customer>());

            DbContext.Init(fluentConfiguration.BuildSessionFactory());
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }
    }
}