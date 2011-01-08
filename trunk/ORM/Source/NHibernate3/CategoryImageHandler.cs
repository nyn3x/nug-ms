// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryImageHandler.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The category image handler.
// 
//   $Id$
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3
{
    using System.Drawing.Imaging;
    using System.Web;
    using Infrastructure;

    /// <summary>
    /// The category image handler.
    /// </summary>
    public class CategoryImageHandler : BaseHttpHandler
    {
        #region Fields

        /// <summary>
        /// The _category id.
        /// </summary>
        private int _categoryId;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the content MIME type.
        /// </summary>
        /// <value></value>
        public override string ContentMimeType
        {
            get { return "image/jpeg"; }
        }

        /// <summary>
        /// Gets a value indicating whether this handler
        /// requires users to be authenticated.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if authentication is required
        /// otherwise, <c>false</c>.
        /// </value>
        public override bool RequiresAuthentication
        {
            get { return false; }
        }

        #endregion

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void HandleRequest(HttpContext context)
        {
            using (var session = DbContext.SessionFactory.OpenSession())
            {
                var category = session.Get<Entities.Category>(_categoryId);
                if (category.Picture != null)
                    category.ImagePhoto.Save(context.Response.OutputStream, ImageFormat.Jpeg);
            }
        }

        /// <summary>
        /// Validates the parameters.  Inheriting classes must
        /// implement this and return true if the parameters are
        /// valid, otherwise false.
        /// </summary>
        /// <param name="context">
        /// Context.
        /// </param>
        /// <returns>
        /// <c>true</c> if the parameters are valid,
        /// otherwise <c>false</c>
        /// </returns>
        public override bool ValidateParameters(HttpContext context)
        {
            return int.TryParse(context.Request.Params["categoryId"], out _categoryId);
        }
    }
}