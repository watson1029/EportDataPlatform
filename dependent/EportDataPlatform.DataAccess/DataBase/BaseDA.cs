using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EportDataPlatform.DataAccess.DataBase
{
    public class BaseDA
    {
        protected readonly Context.EntRetDbContext _context;
        public BaseDA()
        {
            DbContextOptions<Context.EntRetDbContext> dbContextOption = new DbContextOptions<Context.EntRetDbContext>();
            DbContextOptionsBuilder<Context.EntRetDbContext> dbContextOptionBuilder = new DbContextOptionsBuilder<Context.EntRetDbContext>(dbContextOption);
            _context = new Context.EntRetDbContext(dbContextOptionBuilder.UseSqlServer(Helper.ConfigurationHelper.Configuration.GetConnectionString("SqlServer")).Options);
            //_context = new Context.EntRetDbContext
            //    (dbContextOptionBuilder.UseSqlServer(new ConfigurationBuilder()
            //    .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            //    .Build().GetConnectionString("SqlServer"))
            //    .Options);
        }
    }
}
