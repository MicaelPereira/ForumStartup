using Forum.Application.Interface;
using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application
{
    public class AppUser : AppBase<User>, IAppUser
    {
        readonly IServiceUser _serviceUser;
        public AppUser(IServiceUser serviceUser)
            :base(serviceUser)
        {
            _serviceUser = serviceUser;
        }

        public User LoginUser(string email, string password)
        {
            return _serviceUser.LoginUser(email, password);
        }
    }
}
