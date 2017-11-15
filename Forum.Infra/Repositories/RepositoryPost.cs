using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Repositories
{
    public class RepositoryPost : RepositoryBase<Post>, IRepositoryPost
    {
    }
}
