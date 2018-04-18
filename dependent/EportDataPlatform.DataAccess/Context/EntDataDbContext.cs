using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EportDataPlatform.DataAccess.Context
{
    public class EntDataDbContext : DbContext
    {
        public EntDataDbContext(DbContextOptions<EntDataDbContext> options) : base(options)
        { }

        public DbSet<Entity.DataBase.ENTRY_HEAD> ENTRY_HEAD { get; set; }

        public DbSet<Entity.DataBase.ENTRY_LIST> ENTRY_LIST { get; set; }

        public DbSet<Entity.DataBase.Para_YDTExport> Para_YDTExport { get; set; }
    }
}
