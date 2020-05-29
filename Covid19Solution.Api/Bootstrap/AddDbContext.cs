using Microsoft.Extensions.DependencyInjection;
using Covid19Solution.BoundedContext.SqlContext;

namespace Covid19Solution.Api.Bootstrap
{
    public static class AddDbContextExtension
    {
        public static void AddDbContextService(this IServiceCollection serviceCollection)
        {
            #region SqlDbContext
            serviceCollection.AddDbContext<MainSqlDbContext>();
            serviceCollection.AddScoped<IMainDatabaseFacade, MainSqlDbContext>();
            serviceCollection.AddDbContext<LogSqlDbContext>();
            serviceCollection.AddScoped<ILogDatabaseFacade, LogSqlDbContext>();
            #endregion SqlDbContext



        }
    }
}



