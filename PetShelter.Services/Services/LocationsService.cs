using PetShelter.Data.Repos;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;


namespace PetShelter.Services.Services
{
    [AutoBind]
    public class LocationsService : BaseCrudService<LocationDto, ILocationsRepository>, ILocationsService
    {
        public LocationsService(ILocationsRepository repository) : base(repository) { }
        public async Task<IEnumerable<LocationDto>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }
    }
}
