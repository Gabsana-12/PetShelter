using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Services;
using PetShelter.Services.Services;
using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelterMVC.ViewModel;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class PetController : BaseCrudController<PetDto, IPetsRepository, IPetsService, PetEditVM, PetDetailsVM>
    {
        private readonly IPetTypeService _petTypeService;
        private readonly IShelterService _shelterService;
        private readonly IBreedsService _breedService;
        private readonly IUserService _userService;
        private readonly IVaccineService _vaccinesService;

        public PetController(IPetsService service, IMapper mapper, IPetsService petService, IPetTypeService petTypeService, IBreedsService breedService, IShelterService shelterService, IUserService userService, IVaccineService vaccinesService) : base(service, mapper)
        {
            _breedService = breedService;
            _petTypeService = petTypeService;
            _shelterService = shelterService;
            _userService = userService;
            _vaccinesService = vaccinesService;
        }
       
    }
}
