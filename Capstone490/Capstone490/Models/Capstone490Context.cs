using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Capstone490.Models
{
    public class Capstone490Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public Capstone490Context() : base("name=Capstone490Context")
        {
        }

        public System.Data.Entity.DbSet<Capstone490.Models.Survey> Surveys { get; set; }

        public System.Data.Entity.DbSet<Capstone490.Models.Interests> Interests { get; set; }

        public System.Data.Entity.DbSet<Capstone490.Models.Club> Clubs { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Club>().ToTable("xClub");
        //}
    }
}
