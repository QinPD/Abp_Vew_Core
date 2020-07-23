using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_VUE.Configuration;

namespace ABP_VUE.Web.Host.Startup
{
    [DependsOn(
       typeof(ABP_VUEWebCoreModule))]
    public class ABP_VUEWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_VUEWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_VUEWebHostModule).GetAssembly());
        }
    }
}
