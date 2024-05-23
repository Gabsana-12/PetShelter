using AutoMapper;
using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    internal class PetsTypeRepository : BaseRepository<PetsTypeRepository, PetTypeDto>, IPetTypeRepository
    {
        public PetsTypeRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
