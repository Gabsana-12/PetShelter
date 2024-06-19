using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class PetVaccineDetailsVM : BaseVM
    {
        public int PetId { get; set; }
        public PetDetailsVM Pet { get; set; }
        public int VaccineId { get; set; }
        public VaccineDetailsVM Vaccine { get; set; }
        public List<PetDetailsVM> Pets { get; set; }
    }
}
