﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using PetShelter.Services;
using PetShelter.Services.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelterMVC.ViewModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, ISheltersRepository, IShelterService, ShelterEditVM, ShelterDetailsVM>
    {
        public ILocationsService _locationsService { get; set; }

        public ShelterController(IShelterService service, IMapper mapper, ILocationsService locationsService) : base(service, mapper)
        {
            _locationsService = locationsService;
        }
        protected override async Task<ShelterEditVM> PrePopulateVMAsync()
        {
            var editVM = new ShelterEditVM
            {
                LocationList = (await _locationsService.GetAllActiveAsync())
                .Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()))
            };

            return editVM;
        }
    }
}
