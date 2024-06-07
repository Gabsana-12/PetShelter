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
    public class UsersService : BaseCrudService<UserDto, IUsersRepository>, IUserService
    {
        public UsersService(IUsersRepository repository) : base(repository) { }

        public async Task<bool> CanUserLoginAsync(string username, string password)

        {
            return await _repository.CanUserLoginAsync(username, password);
        }
        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            return await _repository.GetByUsernameAsync(username);
        }
    }
}
