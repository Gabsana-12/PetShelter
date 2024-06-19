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
    public class RolesService : BaseCrudService<RoleDto, IRolesRepository>, IRoleService
    {
        public RolesService(IRolesRepository repository) : base(repository) { }
        public Task<RoleDto?> GetByNameIfExistsAsync(string name)
        {
            return _repository.GetByNameIfExistsAsync(name);

        }
    }
}
