using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    internal class UsersRepository : BaseRepository<User, UserDto>, IUsersRepository
    {
        public UsersRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public async Task<bool> CanUserLoginAsync(string username, string password)
        {
            return await _dbSet.AnyAsync(ul => ul.Username == username && ul.Password == password);
        }
    }
}
