// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The Product entity.
// 
//   $Id$
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3.Entities
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The Product entity.
    /// </summary>
    public class Product : EntityBase<Product, int>
    {
        #region Properties

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        #endregion
    }

    /// <summary>
    /// OR-Mapping for the <see cref="Product"/>.
    /// </summary>
    public class ProductMapping : ClassMap<Product>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMapping"/> class. 
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <remarks>
        /// Initializes a new OR-Mapping.
        /// </remarks>
        public ProductMapping()
        {
            Table("Products");
            Id(product => product.Id).Column("ProductID").GeneratedBy.Identity();
            Map(p => p.Name).Column("ProductName");
            References(p => p.Category).Column("CategoryID").LazyLoad();
        }

        #endregion
    }
}