using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class BreedEditVM:BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public BreedSize Size { get; set; }
    }
}
