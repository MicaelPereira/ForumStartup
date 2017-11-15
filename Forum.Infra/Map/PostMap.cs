using FluentNHibernate.Mapping;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Map
{
    class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id).GeneratedBy.SequenceIdentity();
            Map(x => x.Body);
            Map(x => x.CreatedDate);
            Map(x => x.Title);
            Map(x => x.UpdatedDate);
            Map(x => x.TypeOfPost).CustomType<TypeOfPost>();
            References(x => x.User);

            HasMany(x => x.AnswersPost);            

        }
    }
}
