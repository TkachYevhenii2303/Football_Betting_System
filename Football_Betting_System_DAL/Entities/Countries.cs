using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Countries : Entity
    {
        public string Countries_title { get; set; } = string.Empty;

        public virtual ICollection<Towns> Towns { get; set; } = null!;
    }
}
