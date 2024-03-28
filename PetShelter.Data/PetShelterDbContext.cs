using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data
{
    class PetShelterDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PetShelterDbContext(DbContextOptions<PetShelterDbContext> options) : base(options)
        {

        }
    }
}
