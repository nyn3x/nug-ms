// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.aspx.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3
{
    using System;
    using System.Web.UI;
    using Infrastructure;

    /// <summary>
    /// The category.
    /// </summary>
    public partial class Category : Page
    {
        /// <summary>
        /// The on pre render.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            using (var session = DbContext.SessionFactory.OpenSession())
            {
                var query = session.CreateQuery("from Category where Name Like 'C%'").List<Entities.Category>();

                categoryList.DataSource = query;
                categoryList.DataBind();
            }
        }
    }
}