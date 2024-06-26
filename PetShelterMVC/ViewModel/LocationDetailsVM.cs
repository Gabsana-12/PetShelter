﻿using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class LocationDetailsVM : BaseVM
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public int? ShelterId { get; set; }

        public virtual Shelter Shelter { get; set; }
    }
}
