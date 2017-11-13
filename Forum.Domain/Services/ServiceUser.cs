using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;

namespace Forum.Domain.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser repositoryUser)
            : base(repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }


    }
}
