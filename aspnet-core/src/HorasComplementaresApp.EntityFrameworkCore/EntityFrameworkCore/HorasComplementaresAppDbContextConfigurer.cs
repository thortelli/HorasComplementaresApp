using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HorasComplementaresApp.EntityFrameworkCore
{
    public static class HorasComplementaresAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HorasComplementaresAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HorasComplementaresAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
