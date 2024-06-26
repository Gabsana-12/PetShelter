﻿using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class PetTypeDetailsVM : BaseVM
    {
        public string Name { get; set; }
        public List<PetDetailsVM> Pets { get; set; }
    }
}
