using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Repositories
{
    public class RepositoryPost : RepositoryBase<Post>, IRepositoryPost
    {
        public Post GetWithAnswers(int id)
        {
            return Db.QueryOver<Post>()
                .Fetch(j => j.AnswersPost)
                .Lazy
                .Where(q => q.Id == id && q.AnswersPost.Where(a=>a.MainPost.Id == id).Count() > 0)
                .SingleOrDefault();
        }
    }
}
