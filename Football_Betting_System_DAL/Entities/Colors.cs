using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Colors : Entity
    {
        public string Colors_title { get; set; } = string.Empty;

        public virtual ICollection<Teams> Home_teams { get; set; } = null!;

        public virtual ICollection<Teams> Away_teams { get; set; } = null!;
    }
}
