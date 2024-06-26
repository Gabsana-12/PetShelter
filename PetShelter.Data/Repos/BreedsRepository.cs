﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class BreedsRepository : BaseRepository<Breed, BreedDto>, IBreedsRepository
    {
        public BreedsRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
