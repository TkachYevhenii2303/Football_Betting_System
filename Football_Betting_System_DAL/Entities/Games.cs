using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Games : Entity
    {
        public DateTime Date { get; set; }

        public Games_types Games_Types { get; set; } = Games_types.Winner;

        public int Home_teams_Bet_Rate { get; set; } = 0;
        
        public int Away_teams_Bet_Rate { get; set; } = 0;

        public Teams Home_teams { get; set; } = null!;

        public Guid? Home_teams_ID { get; set; }

        public Teams Away_teams { get; set; } = null!;

        public Guid? Away_teams_ID { get; set; }

        public ICollection<PlayersStatistics> PlayersStatistics { get; set; } = null!;

        public ICollection<Bets> Bets { get; set; } = null!;
    }
}
