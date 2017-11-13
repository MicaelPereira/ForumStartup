using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;

namespace Forum.Domain.Services
{
    public class ServiceStartup : ServiceBase<Startup>, IServiceStartup
    {
        IRepositoryStartup _repositoryStartup;
        public ServiceStartup(IRepositoryStartup repositoryStartup)
            : base(repositoryStartup)
        {
            _repositoryStartup = repositoryStartup;
        }


    }
}
