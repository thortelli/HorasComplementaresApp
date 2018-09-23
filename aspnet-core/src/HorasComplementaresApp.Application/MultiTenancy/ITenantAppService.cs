using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HorasComplementaresApp.MultiTenancy.Dto;

namespace HorasComplementaresApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
