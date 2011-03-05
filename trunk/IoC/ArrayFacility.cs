namespace IOC_Sample
{
    using Castle.Core.Configuration;
    using Castle.MicroKernel;
    using Castle.MicroKernel.Resolvers.SpecializedResolvers;

    public class ArrayFacility : IFacility
    {
        #region IFacility Members

        public void Init(IKernel kernel, IConfiguration facilityConfig)
        {
            kernel.Resolver.AddSubResolver(new ArrayResolver(kernel));
        }

        public void Terminate()
        {
        }

        #endregion
    }
}