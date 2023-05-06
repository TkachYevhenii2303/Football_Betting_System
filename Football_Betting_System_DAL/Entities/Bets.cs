using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Bets : Entity
    {
        public string Predictions { get; set; } = string.Empty;

        public string Amount { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public Games Games { get; set; } = null!;

        public Guid Games_ID { get; set; }

        public Users Users { get; set; } = null!;

        public Guid Users_ID { get; set; }
    }
}
