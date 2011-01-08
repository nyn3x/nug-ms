// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityBase.cs" company="Henning Eiben">
//   This is educational code.
// </copyright>
// <summary>
//   An abstract base class for new entities providing basic, common features
//   such as an  and a base implementation of
//   .
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NHibernate3.Entities
{
    using System;

    /// <summary>
    /// An abstract base class for new entities providing basic, common features
    /// such as an <see cref="Id"/> and a base implementation of 
    /// <see cref="IEquatable{T}"/>.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The type of the entity.
    /// </typeparam>
    /// <typeparam name="TId">
    /// The type of the id of the entity.
    /// </typeparam>
    public abstract class EntityBase<TEntity, TId> : IEquatable<TEntity>
        where TEntity : EntityBase<TEntity, TId>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id of the entity.
        /// </summary>
        /// <value>The id.</value>
        public virtual TId Id { get; set; }

        #endregion

        #region IEquatable<TEntity> Members

        /// <summary>
        /// Indicates whether the current object is equal to another object of
        /// the same type.
        /// </summary>
        /// <param name="other">
        /// An object to compare with this object.
        /// </param>
        /// <returns>
        /// <c>true</c> if the current object is equal to the 
        /// <paramref name="other"/> parameter; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool Equals(TEntity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Id.Equals(Id);
        }

        #endregion

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is
        /// equal to this instance.
        /// </summary>
        /// <param name="other">
        /// The <see cref="System.Object"/> to compare with
        /// this instance.
        /// </param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal
        /// 	to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;


// if (other.GetType() != typeof(TEntity)) return false;
            return Equals((TEntity) other);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing
        /// algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return (Id.GetHashCode()*0x18d) ^ GetType().GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(EntityBase<TEntity, TId> left, EntityBase<TEntity, TId> right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(EntityBase<TEntity, TId> left, EntityBase<TEntity, TId> right)
        {
            return !Equals(left, right);
        }

        // Properties
    }
}