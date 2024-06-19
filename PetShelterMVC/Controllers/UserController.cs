using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Repos;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelterMVC.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]

    public class UserController : BaseCrudController<UserDto, IUsersRepository, IUserService, UserEditVM, UserDetailsVM>

    {

        private readonly IRoleService _roleService;

        private readonly IShelterService _shelterService;


        public UserController(IUserService service, IMapper mapper, IRoleService roleService, IShelterService shelterService) : base(service, mapper)

        {

            _shelterService = shelterService;

            _roleService = roleService;

        }

        protected override async Task<UserEditVM> PrePopulateVMAsync(UserEditVM editVM)

        {

            editVM.ShelterList = (await _shelterService.GetAllAsync())

            .Select(x => new SelectListItem(x.PetCapacity.ToString(), x.Id.ToString()));

            editVM.RoleList = (await _roleService.GetAllAsync())

            .Select(x => new SelectListItem(x.Name, x.Id.ToString()));

            return editVM;

        }

    }
}
