using Application.Interfaces.Services;
using Application.Services;
using AutoMapper;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using FreightManagement;
using FreightManagement.AutoMapper;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace FreightManagement
{
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
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
            var config = new MapperConfiguration(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });

            var mapper = config.CreateMapper();
            kernel.Bind<IMapper>().ToConstant(mapper);

            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAppCarrierService>().To<AppCarrierService>();
            kernel.Bind<IAppCarrierPhoneNumberService>().To<AppCarrierPhoneNumberService>();
            kernel.Bind<IAppRatingService>().To<AppRatingService>();
            kernel.Bind<IAppUserService>().To<AppUserService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICarrierService>().To<CarrierService>();
            kernel.Bind<ICarrierPhoneNumberService>().To<CarrierPhoneNumberService>();
            kernel.Bind<IRatingService>().To<RatingService>();
            kernel.Bind<IUserService>().To<UserService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICarrierRepository>().To<CarrierRepository>();
            kernel.Bind<ICarrierPhoneNumberRepository>().To<CarrierPhoneNumberRepository>();
            kernel.Bind<IRatingRepository>().To<RatingRepository>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
        }        
    }
}
