using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;

namespace Forum.Domain.Services
{
    public class ServicePost : ServiceBase<Post>, IServicePost
    {
        IRepositoryPost _repositoryPost;
        public ServicePost(IRepositoryPost repositoryPost)
            : base(repositoryPost)
        {
            _repositoryPost = repositoryPost;
        }


    }
}
