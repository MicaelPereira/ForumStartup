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
    public class AppPost : AppBase<Post>, IAppPost
    {
        readonly IServicePost _servicePost;
        public AppPost(IServicePost servicePost)
            :base(servicePost)
        {
            _servicePost= servicePost;
        }
    }
}
