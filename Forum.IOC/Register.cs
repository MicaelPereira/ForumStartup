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
            
            container.Register<IUserService, UserService>(Lifestyle.Transient);
            //container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Singleton);

            container.Verify();

            return container;
        }

    }
    //TODO: Take off
    internal interface IUserService
    {
        void test();
    }

    internal class UserService : IUserService
    {
        public void test()
        {
            throw new NotImplementedException();
        }
    }
}
