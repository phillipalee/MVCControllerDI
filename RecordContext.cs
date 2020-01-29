using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace MVCControllerDI
{
    public class RecordContext : DbContext
    {
        public virtual DbSet<Record> Records { get; set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            
            optionsBuilder.UseSqlServer (configuration.GetConnectionString("Storage"));
            optionsBuilder.EnableDetailedErrors();
        }

    }
}
