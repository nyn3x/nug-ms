namespace NHibernate3
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using Infrastructure;
    using NHibernate.Linq;

    public partial class Product : Page
    {
        #region Fields

        private int _categoryId;

        #endregion

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

        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(HttpContext.Current.Request.Params["categoryId"], out _categoryId);
        }
    }
}