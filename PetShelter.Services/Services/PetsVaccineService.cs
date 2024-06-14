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
    public class PetsVaccineService : BaseCrudService<PetVaccineDto, IPetsVaccineRepository>, IPetVaccineService
    {
        public PetsVaccineService(IPetsVaccineRepository repository) : base(repository) { }
        public Task VaccinatePetAsync(int petId, int vaccineId)
        {
            return _repository.VaccinatePetAsync(petId, vaccineId);
        }
    }
}
