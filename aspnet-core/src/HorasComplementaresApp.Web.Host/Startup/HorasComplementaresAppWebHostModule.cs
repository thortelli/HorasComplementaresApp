using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HorasComplementaresApp.Configuration;

namespace HorasComplementaresApp.Web.Host.Startup
{
    [DependsOn(
       typeof(HorasComplementaresAppWebCoreModule))]
    public class HorasComplementaresAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HorasComplementaresAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HorasComplementaresAppWebHostModule).GetAssembly());
        }
    }
}
