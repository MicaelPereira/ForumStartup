using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;

namespace Forum.Domain.Services
{
    public class ServiceAnswerPost : ServiceBase<AnswerPost>, IServiceAnswerPost
    {
        IRepositoryAnswerPost _repositoryAnswerPost;
        public ServiceAnswerPost(IRepositoryAnswerPost repositoryAnswerPost)
            : base(repositoryAnswerPost)
        {
            _repositoryAnswerPost = repositoryAnswerPost;
        }


    }
}
