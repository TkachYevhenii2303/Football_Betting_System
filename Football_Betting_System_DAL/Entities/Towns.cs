using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Towns : Entity
    {
        public string Towns_title { get; set; } = string.Empty;

        public Countries Countries { get; set; } = null!;

        public Guid Countries_ID { get; set; } 
    }
}
