namespace NHibernate3.Entities
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The Product entity.
    /// </summary>
    public class Product : EntityBase<Product, int>
    {
        public virtual string Name { get; set; }
        public virtual Category Category { get; set; }
    }

    /// <summary>
    /// OR-Mapping for the <see cref="Product"/>.
    /// </summary>
    public class ProductMapping : ClassMap<Product>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <remarks>Initializes a new OR-Mapping.</remarks> 
        public ProductMapping()
        {
            Table("Products");
            Id(product => product.Id).Column("ProductID").GeneratedBy.Identity();
            Map(p => p.Name).Column("ProductName");
            References(p => p.Category).Column("CategoryID").LazyLoad();
        }
    }
}