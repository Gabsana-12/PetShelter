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
    public class SheltersService : BaseCrudService<ShelterDto, ISheltersRepository>, IShelterService
    {
        public SheltersService(ISheltersRepository repository) : base(repository) { }
    }
}
