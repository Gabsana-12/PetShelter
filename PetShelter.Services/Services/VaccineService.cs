using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    internal class VaccineService : BaseCrudService<VaccineDto, IVaccinesRepository>, IVaccineService
    {
        public VaccineService(IBreedRepository repository) : base(repository) { }
    }
}
