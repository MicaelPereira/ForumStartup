using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain = Forum.Domain.Entities;

namespace Forum.Presentation.Models
{
    public class Post : Base
    {
        public Post()
        {

        }

        public Post(domain.Post post, bool withoutAnswer = false)
        {
            this.Id = post.Id;
            this.CreatedDate = post.CreatedDate;
            this.UpdatedDate = post.UpdatedDate;
            this.AnswersPost = new List<AnswerPost>();
            if (!withoutAnswer && post.AnswersPost != null && post.AnswersPost.Count > 0)
                this.AnswersPost.AddRange(AnswerPost.ParseListDomainToPresentation(post.AnswersPost));
            this.Body = post.Body;
            this.Title = post.Title;
            this.User = new User(post.User);
        }

        public Post(domain.Post post, object userID, bool overrideUser = false)
            : this(post)
        {            
            if (userID != null)
            {
                if(overrideUser)
                    this.User = new User { Id = int.Parse(userID.ToString()) };
                this.CanEdit = post.CanEditPost(int.Parse(userID.ToString()));
            }
                
        }

        public Post(object userID)
        {
            this.User = new User { Id = int.Parse(userID.ToString()) };
        }

        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
        public bool CanEdit { get; set; }

        public List<AnswerPost> AnswersPost { get; set; }

        public static IEnumerable<Post> ParseListDomainToPresentation(IEnumerable<domain.Post> Posts, object userID)
        {
            List<Post> lst = new List<Post>();
            foreach (var item in Posts)
            {
                lst.Add(new Post(item, userID));
            }
            return lst;
        }


    }
}
