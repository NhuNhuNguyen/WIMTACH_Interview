using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCollegeV1.Configuration;

namespace MyCollegeV1.Web.Host.Startup
{
    [DependsOn(
       typeof(MyCollegeV1WebCoreModule))]
    public class MyCollegeV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyCollegeV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCollegeV1WebHostModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            System.AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            System.AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            // https://www.npgsql.org/efcore/release-notes/6.0.html?tabs=annotations
        }
    }
}
