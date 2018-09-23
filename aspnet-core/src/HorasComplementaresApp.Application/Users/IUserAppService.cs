using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HorasComplementaresApp.Roles.Dto;
using HorasComplementaresApp.Users.Dto;

namespace HorasComplementaresApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
