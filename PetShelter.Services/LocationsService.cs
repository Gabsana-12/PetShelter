using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;

namespace PetShelter.Services
{
    public class LocationsService : BaseCrudService<LocationDto, ILocationRepository>, ILocationsService
    {
        public LocationsService(IBreedRepository repository) : base(repository) { }
}
}
