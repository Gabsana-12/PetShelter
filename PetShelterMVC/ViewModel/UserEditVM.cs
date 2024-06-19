using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelterMVC.ViewModel
{
    public class UserEditVM : BaseVM
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int? RoleId { get; set; }

        [Required]
        public int? ShelterId { get; set; }

        public IEnumerable<SelectListItem> RoleList { get; set; }
        public IEnumerable<SelectListItem> ShelterList { get; set; }

    }
}
