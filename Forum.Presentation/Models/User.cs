using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain = Forum.Domain.Entities;

namespace Forum.Presentation.Models
{
    public class User : Base
    {
        public User()
        {

        }

        public User(domain.User user)
        {
            base.CreatedDate = user.CreatedDate;
            base.UpdatedDate = user.UpdatedDate;
            base.Id = user.Id;
            this.Name = user.Name;
            this.Email = user.Email;
            this.Password = user.Password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static IEnumerable<User> ParseListDomainToPresentation(IEnumerable<domain.User> Users)
        {
            List<User> users = new List<User>();
            foreach (var item in Users)
            {
                users.Add(new User(item));
            }
            return users;
        }
    }
}
