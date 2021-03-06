using Stagio.DataLayer;
using Stagio.DataLayer.EntityFramework;
using Stagio.Domain.Entities;
using Stagio.Web.Services;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Stagio.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Stagio.Web.App_Start.NinjectWebCommon), "Stop")]

namespace Stagio.Web.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IEntityRepository<Student>>().To<EfEntityRepository<Student>>().InRequestScope();
            kernel.Bind<IEntityRepository<Coordinator>>().To<EfEntityRepository<Coordinator>>().InRequestScope();
            kernel.Bind<IEntityRepository<Invitation>>().To<EfEntityRepository<Invitation>>().InRequestScope();
            kernel.Bind<IEntityRepository<ApplicationUser>>().To<EfEntityRepository<ApplicationUser>>().InRequestScope();
            kernel.Bind<IEntityRepository<ContactEnterprise>>().To<EfEntityRepository<ContactEnterprise>>().InRequestScope();
            kernel.Bind<IEntityRepository<Stage>>().To<EfEntityRepository<Stage>>().InRequestScope();
            kernel.Bind<IEntityRepository<Apply>>().To<EfEntityRepository<Apply>>().InRequestScope();
            kernel.Bind<IEntityRepository<Interview>>().To<EfEntityRepository<Interview>>().InRequestScope();
            kernel.Bind<IEntityRepository<InvitationContactEnterprise>>().To<EfEntityRepository<InvitationContactEnterprise>>().InRequestScope();
            kernel.Bind<IEntityRepository<Notification>>().To<EfEntityRepository<Notification>>().InRequestScope();
            kernel.Bind<IEntityRepository<StageAgreement>>().To<EfEntityRepository<StageAgreement>>().InRequestScope();
            kernel.Bind<IEntityRepository<Misc>>().To<EfEntityRepository<Misc>>().InRequestScope();

            kernel.Bind<IMailler>().ToConstant(Mailler.Instance);

            kernel.Bind<IDatabaseHelper>().To<EfDatabaseHelper>().InRequestScope();

            kernel.Bind<IHttpContextService>().To<HttpContextService>().InRequestScope();
            kernel.Bind<IAccountService>().To<AccountService>().InRequestScope();
            kernel.Bind<INotificationService>().To<NotificationService>().InRequestScope();


        }        
    }
}
