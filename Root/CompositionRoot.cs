using BLL.Infrastructure;
using BLL.Services;
using BLL.Services.Impl;
using Data;
using Data.Infrastructure;
using Data.Repositories;
using Data.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Root
{
    public class CompositionRoot
    {
        protected CompositionRoot() { }

        public static void InjectDependencies(IServiceCollection services, string connectionString)
        {
            #region // databases injection

            services.AddDbContext<MyDataBaseContext>(opts => opts.UseSqlServer(connectionString, b => b.MigrationsAssembly("Data")));
            services.AddScoped<MyDataBaseContext>();

            #endregion

            #region // generic repository, generic service and unitOfWork injection          

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IServicePattern<>), typeof(ServicePattern<>));           
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            #region // repositories injection         
            
            services.AddScoped<IBungalowRepository, BungalowRepository>();
            services.AddScoped<ICommercialRepository, CommercialRepository>();
            services.AddScoped<IConvenienceRepository, ConvenienceRepository>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();

            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationDayService, ReservationDayService>();
            services.AddScoped<ITenantRepository, TenantRepository>();

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

            #region // services injection

            
            services.AddScoped<IBungalowService, BungalowService>();
            services.AddScoped<ICommercialService, CommercialService>();
            services.AddScoped<IConvenienceService, ConvenienceService>();
            services.AddScoped<IOwnerService, OwnerService>();

            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IReservationDayService, ReservationDayService>();
            services.AddScoped<IReservationService, IReservationService>();
            services.AddScoped<ITenantService, TenantService>();

            services.AddScoped<IUserService, UserService>();
           
            #endregion

           

        }
    }
}
