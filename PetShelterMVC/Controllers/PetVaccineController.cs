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
    public class PetVaccineController : BaseCrudController<PetVaccineDto, IPetsVaccineRepository, IPetVaccineService, PetVaccineDetailsVM, PetVaccineDetailsVM>
    {
        public PetVaccineController(IPetVaccineService service, IMapper mapper) : base(service, mapper) { }
    }
}
