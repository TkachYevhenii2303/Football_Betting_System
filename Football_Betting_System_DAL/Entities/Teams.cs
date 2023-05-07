using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Teams : Entity
    {
        public string Teams_title { get; set; } = string.Empty;

        public string Logos_URL { get; set; } = string.Empty;   

        public string Initials { get; set;} = string.Empty; 

        public string Budget { get; set; } = string.Empty;

        public Towns Towns { get; set; } = null!;

        public Guid Towns_ID { get; set; }

        public virtual Colors? Home_colors { get; set; } = null!;

        public Guid? Home_colors_ID { get; set; }

        public virtual Colors? Away_colors { get; set; } = null!;

        public Guid? Away_colors_ID { get; set; }

        public virtual ICollection<Games> Home_games { get; set; } = null!; 

        public virtual ICollection<Games> Away_games { get; set; } = null!;
    }
}
