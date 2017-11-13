using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class Post : Base
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public virtual User User { get; set; }

        public virtual List<AnswerPost> AnswersPost { get; set; }

    }
}
