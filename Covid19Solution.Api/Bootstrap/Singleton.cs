using Microsoft.Extensions.DependencyInjection;
using Covid19Solution.Infrastructure.Singleton;
using Covid19Solution.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace Covid19Solution.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




