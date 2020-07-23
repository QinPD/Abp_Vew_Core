using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_VUE.EntityFrameworkCore;
using ABP_VUE.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABP_VUE.Web.Tests
{
    [DependsOn(
        typeof(ABP_VUEWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABP_VUEWebTestModule : AbpModule
    {
        public ABP_VUEWebTestModule(ABP_VUEEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_VUEWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABP_VUEWebMvcModule).Assembly);
        }
    }
}