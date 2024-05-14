using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Breed, BreedDto>().ReverseMap();
            CreateMap<BreedDto, BreedEditVM>().ReverseMap();
            CreateMap<BreedDto, BreedDetailsVM>().ReverseMap();
        }
    }
}
