﻿using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IUsersRepository : IBaseRepository<UserDto>
    {
       public Task<bool> CanUserLoginAsync(string username, string password);
        public Task<UserDto> GetByUsernameAsync(string username);
    }
}
