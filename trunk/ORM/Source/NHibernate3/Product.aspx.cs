// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.aspx.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using NHibernate.Linq;
    using Infrastructure;

    /// <summary>
    /// The product.
    /// </summary>
    public partial class Product : Page
    {
        #region Fields

        /// <summary>
        /// The _category id.
        /// </summary>
        private int _categoryId;

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

            using (var session = DbContext.SessionFactory.OpenSession())
            {
                var query = from product in session.Query<Entities.Product>()
                            where product.Category.Id == _categoryId
                            select product;

                productList.DataSource = query;
                productList.DataBind();
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
            int.TryParse(HttpContext.Current.Request.Params["categoryId"], out _categoryId);
        }
    }
}