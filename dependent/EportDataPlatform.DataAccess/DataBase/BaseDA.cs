using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EportDataPlatform.DataAccess.DataBase
{
    public class BaseDa
    {
        protected readonly Context.EntRetDbContext _EntRetContext;
        protected readonly Context.EntDataDbContext _EntDataContext;
        public BaseDa()
        {
            if (string.IsNullOrEmpty(Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetConnectionString("Ent_Ret")))
            {
                //ENT_RET
                DbContextOptions<Context.EntRetDbContext> dbContextOption1 = new DbContextOptions<Context.EntRetDbContext>();
                DbContextOptionsBuilder<Context.EntRetDbContext> dbContextOptionBuilder1 = new DbContextOptionsBuilder<Context.EntRetDbContext>(dbContextOption1);
                _EntRetContext = new Context.EntRetDbContext(dbContextOptionBuilder1.UseSqlServer(Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetConnectionString("Ent_Ret")).Options);
            }
            if (string.IsNullOrEmpty(Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetConnectionString("Ent_Data")))
            {
                //ENT_DATA
                DbContextOptions<Context.EntDataDbContext> dbContextOption2 = new DbContextOptions<Context.EntDataDbContext>();
                DbContextOptionsBuilder<Context.EntDataDbContext> dbContextOptionBuilder2 = new DbContextOptionsBuilder<Context.EntDataDbContext>(dbContextOption2);
                _EntDataContext = new Context.EntDataDbContext(dbContextOptionBuilder2.UseSqlServer(Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetConnectionString("Ent_Data")).Options);
            }
        }
    }
}
