using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Interface
{
    public interface IAppPost : IAppBase<Post>
    {
        Post GetWithAnswers(int id);
        IEnumerable<Post> GetMainPost();
    }
}
