﻿using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface ILocationsRepository : IBaseRepository<LocationDto>
    {
        Task<IEnumerable<LocationDto>> GetAllActiveAsync();
    }
}
