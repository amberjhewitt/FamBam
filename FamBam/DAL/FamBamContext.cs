using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FamBam.DAL
{
    public class FamBamContext : DbContext
    {
        public FamBamContext() : base("FamBamContext")
        {

        }

        public DbSet<Family> Family_Members { get; set; }
        public DbSet<Family_Hobby> Family_Hobbies { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}