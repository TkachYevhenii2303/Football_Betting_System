using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Entities
{
    public class Users : Entity
    {
        public string Name { get; set; } = string.Empty;

        public string Balance { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public ICollection<Bets> Bets { get; set; } = null!;
    }
}
