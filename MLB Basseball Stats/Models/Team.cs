using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MLB_Basseball_Stats.Models
{
    [Table("Table")]
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string League { get; set; }

        public decimal AverageBattingAverage { get; set; }

        public int HomeRuns { get; set; }

        public int RunsBattedIn { get; set; }

        public int Runs { get; set; }
    }
}