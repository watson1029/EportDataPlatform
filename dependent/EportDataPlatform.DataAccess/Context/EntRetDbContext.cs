using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EportDataPlatform.DataAccess.Context
{
    public class EntRetDbContext : DbContext
    {
        public EntRetDbContext(DbContextOptions<EntRetDbContext> options) : base(options)
        {

        }

        public DbSet<Entity.DataBase.ENTRY_RETURN> ENTRY_RETURN { get; set; }
    }
}
