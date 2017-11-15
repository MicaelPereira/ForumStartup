using Forum.Application;
using Forum.Application.Interface;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;
using Forum.Domain.Services;
using Forum.Infra.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.IOC
{
    public static class Register
    {
        public static Container GetContainer()
        {
            var container = new Container();
            
            container.Register<IAppUser, AppUser>(Lifestyle.Singleton);
            container.Register<IServiceUser, ServiceUser>(Lifestyle.Singleton);
            container.Register<IRepositoryUser, RepositoryUser>(Lifestyle.Singleton);

            container.Register<IAppPost, AppPost>(Lifestyle.Singleton);
            container.Register<IServicePost, ServicePost>(Lifestyle.Singleton);
            container.Register<IRepositoryPost, RepositoryPost>(Lifestyle.Singleton);


            container.Verify();

            return container;
        }

    }
}
