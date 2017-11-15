using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Repositories
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        public User LoginUser(string email, string password)
        {
            return base.Db.QueryOver<User>().Where(x => x.Email == email.ToLower() && x.Password == password.ToLower()).SingleOrDefault();
        }
    }
}
