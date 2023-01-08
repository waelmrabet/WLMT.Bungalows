using BLL.Infrastructure.GenericServices;
using BLL.Infrastructure.GenericServices.Impl;
using BLL.Services.Commands;
using BLL.Services.Commands.Impl;
using BLL.Services.Queries;
using BLL.Services.Queries.Impl;
using Data;
using Data.Infrastructure;
using Data.Infrastructure.GenericRepositories;
using Data.Infrastructure.GenericRepositories.Impl;
using Data.Repositories.Commands;
using Data.Repositories.Commands.Impl;
using Data.Repositories.Queries;
using Data.Repositories.Queries.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            #region // generic repo and services injection

            services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));

            services.AddScoped(typeof(ICommandService<>), typeof(CommandService<>));
            services.AddScoped(typeof(IReadService<>), typeof(ReadService<>));


            #endregion

            #region // repositories injection         
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            #endregion

            #region // services injection

            services.AddScoped<IUserCommandServices, UserCommandServices>();
            services.AddScoped<IUserReadService, UserReadService>();



            #endregion

            // inject IUnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
