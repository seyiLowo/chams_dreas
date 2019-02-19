using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chams_dreas.Enum;

namespace chams_dreas.Models
{
class User
    {
        public Guid UserID { get; set; }
        private Roles roles;

        public User(Roles roles)
        {
            this.roles = roles;
        }

    }
}
