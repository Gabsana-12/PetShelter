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
    public class BreedsService : BaseCrudService<BreedDto, IBreedsRepository>, IBreedsService
    {
        public BreedsService(IBreedsRepository repository) : base(repository) { }
    }
}
