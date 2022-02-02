using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace EfCoreExperiment
{
    internal class Program : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public static void Main(string[] args)
        {
            Host
            .CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                    //services.AddScoped<DbContextOptions<ApplicationDbContext>>();
                    services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer("Data Source=.;Initial Catalog=EfTest;Integrated Security=True;");
                });
            })
            .Build().Run();
        }

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Data Source=.;Initial Catalog=EfTest;Integrated Security=True;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
