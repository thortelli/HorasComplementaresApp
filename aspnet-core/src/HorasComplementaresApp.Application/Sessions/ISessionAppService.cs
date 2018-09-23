using System.Threading.Tasks;
using Abp.Application.Services;
using HorasComplementaresApp.Sessions.Dto;

namespace HorasComplementaresApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
