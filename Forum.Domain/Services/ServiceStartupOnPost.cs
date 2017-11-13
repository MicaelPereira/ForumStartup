using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;

namespace Forum.Domain.Services
{
    public class ServiceStartupOnPost : ServiceBase<StartupOnPost>, IServiceStartupOnPost
    {
        IRepositoryStartupOnPost _repositoryStartupOnPost;
        public ServiceStartupOnPost(IRepositoryStartupOnPost repositoryStartupOnPost)
            : base(repositoryStartupOnPost)
        {
            _repositoryStartupOnPost = repositoryStartupOnPost;
        }


    }
}
