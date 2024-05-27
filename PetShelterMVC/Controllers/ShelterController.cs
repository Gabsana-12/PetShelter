using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using PetShelter.Services.Services;
using PetShelterMVC.ViewModel;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    public class ShelterController
    {
        private LocationsService _locationsService;
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
