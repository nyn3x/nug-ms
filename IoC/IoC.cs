namespace IOC_Sample
{
    using System;
    using Castle.Windsor;

    /// <summary>
    /// Wrapper around typical IoC operations
    /// </summary>
    public static class IoC
    {
        #region Fields

        /// <summary>
        /// inner instance of <see cref="WindsorContainer"/>
        /// </summary>
        private static IWindsorContainer _container;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <value>The container.</value>
        /// <exception cref="InvalidOperationException">The container has not
        /// been initialized! Please call <code>IoC.Initialize(container)</code> before using
        /// it.</exception>
        public static IWindsorContainer Container
        {
            get
            {
                var result = _container;
                if (result == null)
                    throw new InvalidOperationException(
                        "The container has not been initialized! Please call IoC.Initialize(container) before using it.");
                return result;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the IoC container has been initialized.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if the container instance is initialized; otherwise, <c>false</c>.
        /// </value>
        public static bool IsInitialized
        {
            get { return _container != null; }
        }

        #endregion

        /// <summary>
        /// Initializes the Inversion-of-Control container with the specified
        /// Castle-Windsor container.
        /// </summary>
        /// <param name="windsorContainer">
        /// The Castle-Windsor container.
        /// </param>
        public static void Initialize(IWindsorContainer windsorContainer)
        {
            _container = windsorContainer;
        }

        /// <summary>
        /// Resolves and returns this instance.
        /// </summary>
        /// <typeparam name="T">
        /// type to be resolved
        /// </typeparam>
        /// <returns>
        /// instance, implementing the type
        /// </returns>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        /// <summary>
        /// Resolves and returns this instance.
        /// </summary>
        /// <typeparam name="T">
        /// type to be resolved
        /// </typeparam>
        /// <returns>
        /// instance, implementing the type
        /// </returns>
        /// <param name="argumentsAsAnonymousType">Arguments, which should be
        /// passed to the constructor of the instance as an anonymous type.
        /// </param>
        public static T Resolve<T>(object argumentsAsAnonymousType)
        {
            return Container.Resolve<T>(argumentsAsAnonymousType);
        }
    }
}