using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public abstract class Entity
    {
        protected internal Guid ID { get; set; }
        
        protected internal DateTime Created_at { get; set; }

        protected internal DateTime? Updated_at { get; set; }
        
        protected Entity()
        {
            ID = Guid.NewGuid();

            Created_at = DateTime.Now;

            Updated_at = null;
        }
    }
}
