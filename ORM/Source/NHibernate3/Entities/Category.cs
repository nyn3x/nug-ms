// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The Category entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3.Entities
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The Category entity.
    /// </summary>
    public class Category : EntityBase<Category, int>
    {
        #region Properties

        /// <summary>
        /// Gets or sets ImagePhoto.
        /// </summary>
        public virtual Bitmap ImagePhoto
        {
            get
            {
                if (Picture == null) return null;

                using (var memoryStream = new MemoryStream(Picture))
                {
                    return (Bitmap) Image.FromStream(memoryStream);
                }
            }

            set { Picture = ImageToByteArray(value); }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets Picture.
        /// </summary>
        public virtual byte[] Picture { get; set; }

        /// <summary>
        /// Gets or sets Products.
        /// </summary>
        public virtual IList<Product> Products { get; set; }

        #endregion

        /// <summary>
        /// The image to byte array.
        /// </summary>
        /// <param name="image">
        /// The image.
        /// </param>
        /// <returns>
        /// </returns>
        private byte[] ImageToByteArray(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.Flush();
                return memoryStream.ToArray();
            }
        }
    }

    /// <summary>
    /// OR-Mapping for the <see cref="Category"/>.
    /// </summary>
    public class CategoryMapping : ClassMap<Category>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryMapping"/> class. 
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <remarks>
        /// Initializes a new OR-Mapping.
        /// </remarks>
        public CategoryMapping()
        {
            Table("Categories");
            Id(category => category.Id).Column("CategoryID").GeneratedBy.Identity();
            Map(c => c.Name).Column("CategoryName");
            Map(c => c.Picture).Column("Picture");
            HasMany(c => c.Products)
                .AsList()
                .LazyLoad();
        }

        #endregion
    }

    namespace Pizza.Web
    {
    }
}