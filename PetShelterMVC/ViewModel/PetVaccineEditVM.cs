using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetShelterMVC.ViewModel
{
    public class PetVaccineEditVM: BaseVM
    {
        [Required]
        public int PetId { get; set; }
        [Required]
        public int VaccineId { get; set; }

        public IEnumerable<SelectListItem> PetList { get; set; }
        public IEnumerable<SelectListItem> VaccineList { get; set; }
    }
}
