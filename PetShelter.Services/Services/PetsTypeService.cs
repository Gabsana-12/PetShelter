using PetShelter.Data.Repos;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    [AutoBind]
    public class PetsTypeService : BaseCrudService<PetTypeDto, IPetsTypeRepository>, IPetTypeService
    {
        public PetsTypeService(IPetsTypeRepository repository) : base(repository) { }
    }
}
