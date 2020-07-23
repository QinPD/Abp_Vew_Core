using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABP_VUE.Configuration;
using ABP_VUE.Web;

namespace ABP_VUE.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABP_VUEDbContextFactory : IDesignTimeDbContextFactory<ABP_VUEDbContext>
    {
        public ABP_VUEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABP_VUEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABP_VUEDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABP_VUEConsts.ConnectionStringName));

            return new ABP_VUEDbContext(builder.Options);
        }
    }
}
