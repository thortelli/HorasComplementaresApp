using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HorasComplementaresApp.Authorization;

namespace HorasComplementaresApp
{
    [DependsOn(
        typeof(HorasComplementaresAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HorasComplementaresAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HorasComplementaresAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HorasComplementaresAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
