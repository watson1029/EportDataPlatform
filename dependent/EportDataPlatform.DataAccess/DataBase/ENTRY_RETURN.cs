using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EportDataPlatform.DataAccess.DataBase
{
    public class ENTRY_RETURN : BaseDA
    {
        //private static IConfiguration Configuration { get; }
        //private static DbContextOptions<Context.EntRetDbContext> option = new DbContextOptions<Context.EntRetDbContext>();
        //private static DbContextOptionsBuilder<Context.EntRetDbContext> builder = new DbContextOptionsBuilder<Context.EntRetDbContext>(option);
        //private static Context.EntRetDbContext _context = new Context.EntRetDbContext(builder.UseSqlServer(Configuration.GetConnectionString("SqlServer")).Options);

        public IList<Entity.DataBase.ENTRY_RETURN> GetAll()
        {
            var linq = from r in _context.ENTRY_RETURN
                       select r;
            return linq.ToList();
        }
    }
}
