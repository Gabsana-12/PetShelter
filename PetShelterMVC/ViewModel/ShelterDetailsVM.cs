using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class ShelterDetailsVM:BaseVM
    {
        public ShelterDetailsVM()
        {
            this.Pets = new List<PetDetailsVM>();
            this.Employees = new List<UserDetailsVM>();
        }

        public int PetCapacity { get; set; }
        public int LocationId { get; set; }
        public List<UserDetailsVM> Employees { get; set; }
        public List<PetDetailsVM> Pets { get; set; }
    }
}
