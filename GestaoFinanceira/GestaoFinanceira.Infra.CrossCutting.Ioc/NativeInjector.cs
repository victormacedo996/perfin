using GestaoFinanceira.Application.Interfaces;
using GestaoFinanceira.Application.Services;
using GestaoFinanceira.Domain.Interfaces.Repositories;
using GestaoFinanceira.Domain.Interfaces.UnitOfWork;
using GestaoFinanceira.Infra.Context;
using GestaoFinanceira.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoFinanceira.Infra.CrossCutting.Ioc
{
    public static class NativeInjector
    {
        #region Public Methods

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddDbContext<GestaoFinanceiraContext>();

            //Application
            services.AddScoped<IUserApplication, UserService>();

            //Repositorios
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        #endregion Public Methods
    }
}