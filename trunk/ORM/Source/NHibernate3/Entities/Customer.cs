// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   The Customer entity.
// 
//   $Id$
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3.Entities
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The Customer entity.
    /// </summary>
    public class Customer : EntityBase<Customer, string>
    {
        #region Properties

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        #endregion
    }

    /// <summary>
    /// OR-Mapping for the <see cref="Customer"/>.
    /// </summary>
    public class CustomerMapping : ClassMap<Customer>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMapping"/> class. 
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <remarks>
        /// Initializes a new OR-Mapping.
        /// </remarks>
        public CustomerMapping()
        {
            Table("Customers");
            Id(customer => customer.Id).Column("CustomerID").GeneratedBy.Assigned();
            Map(c => c.Name).Column("CompanyName");
        }

        #endregion
    }
}