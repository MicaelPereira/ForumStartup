using Forum.Domain.Entities;
using Forum.Domain.Interfaces.Repositories;
using Forum.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Forum.Domain.Services
{
    public class ServicePost : ServiceBase<Post>, IServicePost
    {
        IRepositoryPost _repositoryPost;
        IRepositoryAnswerPost _repositoryAnswerPost;
        public ServicePost(IRepositoryPost repositoryPost, IRepositoryAnswerPost repositoryAnswer)
            : base(repositoryPost)
        {
            _repositoryPost = repositoryPost;
            _repositoryAnswerPost = repositoryAnswer;
        }

        public IEnumerable<Post> GetMainPost()
        {
            return _repositoryPost.GetAll().Where(x=>x.TypeOfPost == TypeOfPost.Main);
        }

        public Post GetWithAnswers(int id)
        {
            var post = _repositoryPost.GetById(id);
            post.AnswersPost = new List<AnswerPost>();
            foreach (var item in _repositoryAnswerPost.GetAnswerSpecificPost(id))
            {
                post.AnswersPost.Add(item);
            }
            return post;
        }
    }
}

