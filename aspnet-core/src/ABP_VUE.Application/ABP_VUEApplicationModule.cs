using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_VUE.Authorization;

namespace ABP_VUE
{
    [DependsOn(
        typeof(ABP_VUECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABP_VUEApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABP_VUEAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABP_VUEApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
