using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
