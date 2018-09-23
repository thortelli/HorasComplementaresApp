using System.Threading.Tasks;
using Abp.Application.Services;
using HorasComplementaresApp.Authorization.Accounts.Dto;

namespace HorasComplementaresApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
