using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{

    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class BreedController : BaseCrudController<BreedDto, IBreedRepository, IBreedsService, BreedEditVM, BreedDetailsVM>
    {
    }
}
