using domain = Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Presentation.Models
{
    public class AnswerPost : Base
    {

        public AnswerPost()
        {

        }

        public AnswerPost(domain.AnswerPost answerPost)
        {
            this.Id = answerPost.Id;
            this.CreatedDate = answerPost.CreatedDate;
            this.UpdatedDate = answerPost.UpdatedDate;
            this.MainPost = new Post(answerPost.MainPost);
            this.Answer = new Post(answerPost.Answer);
        }
        public Post MainPost { get; set; }
        public Post Answer { get; set; }


        public static IEnumerable<AnswerPost> ParseListDomainToPresentation(IEnumerable<domain.AnswerPost> AnswersPosts)
        {
            List<AnswerPost> lst = new List<AnswerPost>();
            if (AnswersPosts != null)
            {
                foreach (var item in AnswersPosts)
                {
                    lst.Add(new AnswerPost(item));
                }
            }
            return lst;
        }
    }
}
