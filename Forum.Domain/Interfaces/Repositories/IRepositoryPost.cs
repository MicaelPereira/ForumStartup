﻿using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Interfaces.Repositories
{
    public interface IRepositoryPost : IRepositoryBase<Post>
    {
        Post GetWithAnswers(int id);
    }
}
