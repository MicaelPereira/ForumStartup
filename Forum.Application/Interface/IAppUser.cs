﻿using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Interface
{
    public interface IAppUser : IAppBase<User>
    {
        User LoginUser(string email, string password);
    }
}
