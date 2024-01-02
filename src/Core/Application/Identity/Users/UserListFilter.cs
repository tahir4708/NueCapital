using NueCapital.WebApi.Application.Common.Models;

namespace NueCapital.WebApi.Application.Identity.Users;

public class UserListFilter : PaginationFilter
{
    public bool? IsActive { get; set; }
}