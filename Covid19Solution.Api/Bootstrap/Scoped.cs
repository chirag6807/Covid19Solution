#region Namespace
using Microsoft.Extensions.DependencyInjection;
using Covid19Solution.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using Covid19Solution.UnitOfWork.DbEntityAudit;
using Covid19Solution.BoundedContext.Main;
using Covid19Solution.UnitOfWork.Main;
using Covid19Solution.Domain.UserModule;
            #endregion Namespace




namespace Covid19Solution.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IMasterContext, MasterContext>();
            serviceCollection.AddScoped<IMasterUow, MasterUow>();
                        serviceCollection.AddScoped<IUserContext, UserContext>();
            serviceCollection.AddScoped<IUserUow, UserUow>();
            #endregion ContextService





            #region DomainService

            
            serviceCollection.AddScoped<IUserDomain, UserDomain>();
            #endregion DomainService

        }
    }
}




