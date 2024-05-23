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
    internal class PetsRepository : BaseRepository<Pet, PetDto>, IPetsRepository
    {
        public PetsRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}