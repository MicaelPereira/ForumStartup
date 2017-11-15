using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class Post : Base
    {
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
        public virtual User User { get; set; }

        public virtual IList<AnswerPost> AnswersPost { get; set; }

        public virtual bool CanEditPost(int UserId)
        {
            return User.Id == UserId && (this.AnswersPost == null || this.AnswersPost.Count <= 0);
        }
    }
}
