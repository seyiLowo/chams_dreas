using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chams_dreas.Models
{
    public class BaseModel
    {
        public string EntryBy { get; set; }
        public DateTime EntryDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
