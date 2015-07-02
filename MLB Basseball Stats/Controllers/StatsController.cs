using Microsoft.Ajax.Utilities;
using MLB_Baseball_Stats.Models;
using MLB_Basseball_Stats.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Context = MLB_Basseball_Stats.Models.Context;

namespace MLB_Basseball_Stats.Controllers
{
    public class StatsController : ApiController
    {
        private StatsController()
        {
            Database.SetInitializer<Context>(null);
        }

        [HttpGet]
        [Route("api/Stats/table")]
        public IEnumerable<Team> GetTable()
        {
            using (var db = new Context())
            {
                return db.team.ToList();
            }
        }
    }
}