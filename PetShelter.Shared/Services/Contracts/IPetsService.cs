using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    public interface IPetsService : IBaseCrudService<PetDto, IPetsRepository>
    {
        Task GivePetAsync(int userId, int shelterId, PetDto pet);
        Task VaccinatePetAsync(int vaccineId, int petId);
        Task AdoptPetAsync(int userId, int petId);
    }
}
