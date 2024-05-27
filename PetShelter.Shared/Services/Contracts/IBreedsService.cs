using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;

namespace PetShelter.Services
{
    public interface IBreedsService : IBaseCrudService<BreedDto, IBreedRepository>
    {
    }
}