﻿using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class UserDetailsVM : BaseVM
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }

        public RoleDetailsVM Role { get; set; }

        public int? ShelterId { get; set; }

        public ShelterDetailsVM Shelter { get; set; }

        public virtual List<Pet> AdoptedPets { get; set; }

        public virtual List<Pet> GivenPets { get; set; }
        public virtual List<Pet> Pets { get; set; }
    }
}
