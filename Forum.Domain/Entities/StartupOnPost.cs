using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class StartupOnPost : Base
    {
        public virtual Post Post { get; set; }
        public virtual Startup Startup { get; set; }

    }
}
