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
    internal class PetsVaccineService : BaseCrudService<PetVaccineDto, IPetsVaccineRepository>, ILocationsService
    {
        public PetsVaccineService(IBreedRepository repository) : base(repository) { }
    }
}
