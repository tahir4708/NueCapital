using Microsoft.AspNetCore.Authorization;
using NueCapital.WebApi.Shared.Authorization;

namespace NueCapital.WebApi.Infrastructure.Auth.Permissions;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}