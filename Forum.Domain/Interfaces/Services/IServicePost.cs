﻿using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Interfaces.Services
{
    public interface IServicePost : IServiceBase<Post>
    {
        Post GetWithAnswers(int id);
        IEnumerable<Post> GetMainPost();
    }
}
