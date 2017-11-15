using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class AnswerPost : Base
    {
        public virtual Post MainPost { get; set; }
        public virtual Post Answer { get; set; }
    }
}
