using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelterMVC.ViewModel;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class RoleController : BaseCrudController<RoleDto, IRolesRepository, IRoleService, RoleEditVM, RoleDetailsVM>
    {
        public RoleController(IRoleService service, IMapper mapper) : base(service, mapper) { }
    }
}
