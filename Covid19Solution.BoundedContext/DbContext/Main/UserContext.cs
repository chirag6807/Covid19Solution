using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Covid19Solution.BoundedContext.SqlContext;
using Covid19Solution.Models.Main;
using Covid19Solution.Models;
using Covid19Solution.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace Covid19Solution.BoundedContext.Main
{
    public class UserContext : BaseBoundedContext, IUserContext
    {
        public UserContext(MainSqlDbContext sqlDbContext, IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor, ITenantDbConnectionInfo tenantDbConnection) : base(sqlDbContext, databaseConfig.Value, contextAccessor, tenantDbConnection) { }

        #region DbSets
        public DbSet<vUser> vUsers { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion DbSets


    }


    public interface IUserContext : IDbContext
    {
    }
}

