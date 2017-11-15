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
    public class AppAnswerPost : AppBase<AnswerPost>, IAppAnswerPost
    {
        readonly IServiceAnswerPost _serviceAnswerPost;
        public AppAnswerPost(IServiceAnswerPost serviceAnswerPost)
            :base(serviceAnswerPost)
        {
            _serviceAnswerPost= serviceAnswerPost;
        }
    }
}
