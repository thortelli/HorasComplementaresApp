using Abp.MultiTenancy;
using HorasComplementaresApp.Authorization.Users;

namespace HorasComplementaresApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
