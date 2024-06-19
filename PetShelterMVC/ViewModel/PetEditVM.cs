using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class PetEditVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public bool IsAdopted { get; set; }

        [Required]
        public bool IsEuthanized { get; set; }

        [Required]
        public int PetTypeId { get; set; }

        [Required]
        public int BreedId { get; set; }

        [Required]
        public int? AdopterId { get; set; }

        [Required]
        public int? GiverId { get; set; }

        [Required]
        public int? ShelterId { get; set; }

        public IEnumerable<SelectListItem> PetTypeList { get; set; }
        public IEnumerable<SelectListItem> BreedList { get; set; }
        public IEnumerable<SelectListItem> ShelterList { get; set; }
    }
}
