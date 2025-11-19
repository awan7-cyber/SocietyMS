using Microsoft.EntityFrameworkCore;
using SocietyMS.Models;

namespace SocietyMS.Data
{
    public class Dbcontext:DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options):base(options) { }  
        //creating all models dbset
       

        public DbSet<Charges> Charges { get; set; }
        public DbSet<Dues> Dues { get; set; }

        public DbSet<Plot> Plots { get; set; }

        public DbSet<Block> Blocks { get; set; }
        public DbSet<Membershipinfo> Membershipinfos { get; set; }

        public DbSet<Personalinfo> Personalinfos
        { get; set; }


       


        public DbSet<Trsfrmembership> Trsfrmemberships { get; set; }


    }
}
