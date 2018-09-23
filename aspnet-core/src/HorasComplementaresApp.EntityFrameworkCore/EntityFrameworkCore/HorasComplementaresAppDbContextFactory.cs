using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HorasComplementaresApp.Configuration;
using HorasComplementaresApp.Web;

namespace HorasComplementaresApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HorasComplementaresAppDbContextFactory : IDesignTimeDbContextFactory<HorasComplementaresAppDbContext>
    {
        public HorasComplementaresAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HorasComplementaresAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HorasComplementaresAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HorasComplementaresAppConsts.ConnectionStringName));

            return new HorasComplementaresAppDbContext(builder.Options);
        }
    }
}
