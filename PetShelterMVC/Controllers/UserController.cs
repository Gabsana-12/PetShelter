using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelterMVC.ViewModel;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class UserController : BaseCrudController<UserDto, IUsersRepository, IUserService, UserEditVM, UserDetailsVM>
    {
        private readonly IRoleService _roleService;
        private readonly IShelterService _shelterService;


        public UserController(IUserService service, IMapper mapper, IRoleService _roleService, IShelterService _shelterService) : base(service, mapper)
        {

        }
    }
}
