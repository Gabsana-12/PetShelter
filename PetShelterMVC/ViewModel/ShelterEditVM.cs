using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class ShelterEditVM
    {
        [Required]
        public int PetCapacity { get; set; }
        [Required]
        [DisplayName("Location")]
        public int LocationId { get; set; }
        public IEnumerable<SelectListItem> LocationList { get; set; }
    }
}
