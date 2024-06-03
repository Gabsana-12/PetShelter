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
    public class VaccineController : BaseCrudController<VaccineDto, IVaccinesRepository, IVaccineService, VaccineEditVM, VaccineDetailsVM>
    {
        public VaccineController(IVaccineService service, IMapper mapper) : base(service, mapper) { }
    }
}
