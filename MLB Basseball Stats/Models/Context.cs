using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace MLB_Basseball_Stats.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Statistics")
        {
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }*/

        public DbSet<Team> team { get; set; }

        public DbSet<Player> player { get; set; }

        //DbSet<Id> id{ get; set; }

        /*internal string Metadata()
        {
            throw new NotImplementedException();
        }*/
    }
}