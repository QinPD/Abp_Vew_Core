using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP_VUE.EntityFrameworkCore
{
    public static class ABP_VUEDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABP_VUEDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABP_VUEDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
