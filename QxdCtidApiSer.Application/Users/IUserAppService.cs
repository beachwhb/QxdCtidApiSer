using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QxdCtidApiSer.Roles.Dto;
using QxdCtidApiSer.Users.Dto;

namespace QxdCtidApiSer.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}