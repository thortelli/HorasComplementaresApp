using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HorasComplementaresApp.Authorization.Roles;
using HorasComplementaresApp.Authorization.Users;
using HorasComplementaresApp.MultiTenancy;

namespace HorasComplementaresApp.EntityFrameworkCore
{
    public class HorasComplementaresAppDbContext : AbpZeroDbContext<Tenant, Role, User, HorasComplementaresAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HorasComplementaresAppDbContext(DbContextOptions<HorasComplementaresAppDbContext> options)
            : base(options)
        {
        }
    }
}
