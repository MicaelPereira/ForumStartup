using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Repositories
{
    public class RepositoryAnswerPost : RepositoryBase<AnswerPost>, IRepositoryAnswerPost
    {
        public IEnumerable<AnswerPost> GetAnswerSpecificPost(int idPost)
        {
            return Db.QueryOver<AnswerPost>().Where(x => x.MainPost.Id == idPost).List();
        }
    }
}
