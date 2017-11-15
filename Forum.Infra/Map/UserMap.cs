using FluentNHibernate.Mapping;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Map
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).GeneratedBy.SequenceIdentity();
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedDate);
            Map(x => x.Name);
            Map(x => x.Password);
            Map(x => x.Email);
        }
    }
}
