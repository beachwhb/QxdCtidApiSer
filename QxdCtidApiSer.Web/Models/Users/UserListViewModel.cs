using System.Collections.Generic;
using QxdCtidApiSer.Roles.Dto;
using QxdCtidApiSer.Users.Dto;

namespace QxdCtidApiSer.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}