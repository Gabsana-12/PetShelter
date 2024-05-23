﻿using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
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
    }
}
