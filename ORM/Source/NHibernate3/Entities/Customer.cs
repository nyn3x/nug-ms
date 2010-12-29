namespace NHibernate3.Entities
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The Customer entity.
    /// </summary>
    public class Customer : EntityBase<Customer, string>
    {
        public virtual string Name { get; set; }
    }

    /// <summary>
    /// OR-Mapping for the <see cref="Customer"/>.
    /// </summary>
    public class CustomerMapping : ClassMap<Customer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <remarks>Initializes a new OR-Mapping.</remarks> 
        public CustomerMapping()
        {
            Table("Customers");
            Id(customer => customer.Id).Column("CustomerID").GeneratedBy.Assigned();
            Map(c=>c.Name).Column("CompanyName");
        }
    }
}