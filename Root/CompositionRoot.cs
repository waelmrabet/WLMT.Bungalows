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
            services.AddScoped<IUserRepository, UserRepository>();           
            #endregion

            #region // services injection

            services.AddScoped<IUserService, UserService>();
           
            #endregion

           

        }
    }
}
