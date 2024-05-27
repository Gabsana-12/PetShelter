using PetShelter.Data.Repos;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    internal class PetsTypeService : BaseCrudService<PetTypeDto, IPetsTypeRepository>, IPetsTypeService
    {
        public PetsTypeService(IBreedRepository repository) : base(repository) { }
    }
}
