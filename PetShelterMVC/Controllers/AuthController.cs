using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Services;
using PetShelter.Services.Services;

namespace PetShelterMVC.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly IUserService userServices;
        private readonly IRoleService rolesServices;
        private readonly IMapper mapper;

        public AuthController(IUserService usersService,
            IRoleService rolesService,
            IMapper mapper)
        {
            this.userServices = usersService;
            this.rolesServices = rolesService;
            this.mapper = mapper;
        }
    }
}
