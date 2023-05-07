using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class PlayersStatistics
    {
        public int Assist { get; set; } = 0;

        public int Minutes_Playing { get; set; } = 0;

        public int Scored_Goals { get; set; } = 0;

        public DateTime Created_at { get; set; } = DateTime.Now;

        public DateTime? Updated_at { get; set; } = null;

        public Players Players { get; set; } = null!;

        public Guid? Playes_ID { get; set; }

        public Games Games { get; set; } = null!;   

        public Guid? Games_ID { get; set; }
    }
}
