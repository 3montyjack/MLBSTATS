using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using MLB_Basseball_Stats.Models;
using Breeze.ContextProvider;

namespace MLB_Baseball_Stats.Models
{
    public interface IRepository
    {

        IQueryable<Team> GetAllTeams();
        
        //Order GetOrder(int Id);

        //string MetaData { get; }

        //SaveResult SaveChanges(JObject saveBundle);

        //IQueryable<Team> Teams();

    }
}
