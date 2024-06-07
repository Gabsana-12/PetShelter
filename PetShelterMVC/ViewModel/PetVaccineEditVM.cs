using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelterMVC.ViewModel
{
    public class PetVaccineEditVM: BaseVM
    {
        public virtual List<PetVaccine> PetList { get; set; }
        public virtual List<PetVaccine> VaccineList { get; set; }
        public int PetId { get; set; }
        public int VaccineId { get; set; }
    }
}
