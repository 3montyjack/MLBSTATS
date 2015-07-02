using MLB_Baseball_Stats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLB_Basseball_Stats.Models
{
    public class Repository : IRepository
    {
        private Context db;

        public IQueryable<Team> GetAllTeams()
        {
            return db.team;
        }

        /*internal List<Team> Retrieve()
        {
            var SQL = db.
        }

        internal Team Save(int id, Team team)
        {
        }*/

        /*public string Metadata
        {
            get { return db.Metadata()}
        }*/

        //public
    }
}