namespace IOC_Sample
{
    using System;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Notification;
    using ServiceWatch;

    internal class Program
    {
        private static void BootStrapIoC()
        {
            IoC.Initialize(new WindsorContainer());

            IoC.Container.AddFacility<ArrayFacility>();
            //IoC.Container.Register(AllTypes
            //                           .FromThisAssembly()
            //                           .BasedOn(typeof (INotifier))
            //                           .WithService.AllInterfaces()
            //                           .WithService.Self()
            //                           .Configure(c => c.LifeStyle.Transient)
            //    );

            IoC.Container.Register(Component
                .For<INotifier>()
                .ImplementedBy<EmailNotifier>()
                .LifeStyle.Transient
                .DependsOn(Property.ForKey("MailServer").Eq("mail.busitec.de"))
                );

            IoC.Container.Register(Component
                                       .For<IServiceWatcher>()
                                       .ImplementedBy<ServiceWatcher>()
                                       .LifeStyle.Transient
                );

            IoC.Container.Register(Component
                                       .For<EnhancedServiceWatcher>()
                                       .ImplementedBy<EnhancedServiceWatcher>()
                                       .LifeStyle.Transient
                );
        }

        private static void Main(string[] args)
        {
            BootStrapIoC();

            IServiceWatcher watcher = IoC.Resolve<EnhancedServiceWatcher>();

            watcher.StartWatching();
            Console.WriteLine("press any key to stop ther service watcher!");
            Console.ReadLine();
        }
    }
}