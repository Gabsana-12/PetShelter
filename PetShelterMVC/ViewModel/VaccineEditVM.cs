using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class VaccineEditVM : BaseVM
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<PetVaccine> PetVaccines { get; set; }
    }
}
