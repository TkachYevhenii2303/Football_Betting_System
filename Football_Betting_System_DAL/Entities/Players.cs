using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Players : Entity
    {
        public string Players_title { get; set; } = string.Empty;

        public int Command_number { get; set; } = 0;

        public bool Is_Injured { get; set; } = false;

        public Teams Teams { get; set; } = null!;

        public Guid Teams_ID { get; set; }

        public Positions Positions { get; set; } = null!;

        public Guid Positions_ID { get; set; }

        public ICollection<PlayersStatistics> PlayersStatistics { get; set; } = null!;
    }
}
