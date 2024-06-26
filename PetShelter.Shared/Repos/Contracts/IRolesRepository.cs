﻿using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IRolesRepository : IBaseRepository<RoleDto>
    {
        Task<RoleDto?> GetByNameIfExistsAsync(string name);
    }
}
