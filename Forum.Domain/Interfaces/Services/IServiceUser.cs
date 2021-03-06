﻿using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Interfaces.Services
{
    public interface IServiceUser : IServiceBase<User>
    {
        User LoginUser(string email, string password);
    }
}
