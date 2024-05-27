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
    public class PetsService : BaseCrudService<PetDto, IPetsRepository>, IPetsService
    {
        public PetsService(IBreedRepository repository) : base(repository) { }
    }
}
