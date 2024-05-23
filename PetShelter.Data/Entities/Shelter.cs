using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PetShelter.Data.Entities
{
    public class Shelter : BaseEntity
    {
        public Shelter()
        {
            this.Pets = new List<Pet>();
            this.Employees = new List<User>();
        }

        public int PetCapacity { get; set; }

        public int BreedId { get; set; }

        public virtual Breed Breed { get; set; }

        public virtual List<User> Employees { get; set; }

        public virtual List<Pet> Pets { get; set; }

    }
}
