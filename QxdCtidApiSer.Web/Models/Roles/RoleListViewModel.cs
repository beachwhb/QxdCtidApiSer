using System.Collections.Generic;
using QxdCtidApiSer.Roles.Dto;

namespace QxdCtidApiSer.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}