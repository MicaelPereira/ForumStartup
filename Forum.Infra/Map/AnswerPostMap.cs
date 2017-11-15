using FluentNHibernate.Mapping;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Map
{
    class AnswerPostMap : ClassMap<AnswerPost>
    {
        public AnswerPostMap()
        {
            Id(x => x.Id).GeneratedBy.SequenceIdentity();
            Map(x => x.CreatedDate);            
            Map(x => x.UpdatedDate);

            References(x => x.MainPost);
            References(x => x.Answer);
            
        }
    }
}
