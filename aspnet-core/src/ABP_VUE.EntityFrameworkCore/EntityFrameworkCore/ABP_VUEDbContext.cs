using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP_VUE.Authorization.Roles;
using ABP_VUE.Authorization.Users;
using ABP_VUE.MultiTenancy;

namespace ABP_VUE.EntityFrameworkCore
{
    public class ABP_VUEDbContext : AbpZeroDbContext<Tenant, Role, User, ABP_VUEDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABP_VUEDbContext(DbContextOptions<ABP_VUEDbContext> options)
            : base(options)
        {
        }
    }
}
