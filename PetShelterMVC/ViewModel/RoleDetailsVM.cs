using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class RoleDetailsVM : BaseVM
    {
        public RoleDetailsVM()
        {
            this.Users = new List<UserDetailsVM>();
            this.Pets = new List<PetDetailsVM>();
        }
        public string Name { get; set; }
        public virtual List<UserDetailsVM> Users { get; set; }
        public virtual List<PetDetailsVM> Pets { get; set; }
    }
}
