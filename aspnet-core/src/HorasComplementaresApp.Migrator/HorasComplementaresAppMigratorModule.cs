using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HorasComplementaresApp.Configuration;
using HorasComplementaresApp.EntityFrameworkCore;
using HorasComplementaresApp.Migrator.DependencyInjection;

namespace HorasComplementaresApp.Migrator
{
    [DependsOn(typeof(HorasComplementaresAppEntityFrameworkModule))]
    public class HorasComplementaresAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HorasComplementaresAppMigratorModule(HorasComplementaresAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(HorasComplementaresAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                HorasComplementaresAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HorasComplementaresAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
