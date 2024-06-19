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
    public class PetsService : BaseCrudService<PetDto, IPetsRepository>, IPetsService
    {
        public PetsService(IPetsRepository repository) : base(repository) { }
        public Task AdoptPetAsync(int userId, int petId)
        {
            return _repository.AdoptPetAsync(userId, petId);

        }

        public Task GivePetAsync(int userId, int shelterId, PetDto pet)
        {
            return _repository.GivePetAsync(userId, shelterId, pet);

        }
        public Task VaccinatePetAsync(int vaccineId, int shelterId)
        {
            return _repository.VaccinatePetAsync(vaccineId, shelterId);

        }
    }
}
