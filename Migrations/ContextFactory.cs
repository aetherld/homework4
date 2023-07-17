using ConsoleApp7.DataBaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Migrations
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionBuilder.UseSqlServer(connectionString, assembly => assembly.MigrationsAssembly("Migrations"));
            return new ApplicationContext(optionBuilder.Options);
        }
    }
}
