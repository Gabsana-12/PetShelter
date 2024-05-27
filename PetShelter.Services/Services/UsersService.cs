using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    internal class UsersService : BaseCrudService<UserDto, IUsersRepository>, IUsersService
    {
        public UsersService(IBreedRepository repository) : base(repository) { }
    }
}
