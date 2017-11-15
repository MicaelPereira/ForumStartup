using FluentNHibernate.Mapping;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Map
{
    class StartupOnPostMap : ClassMap<StartupOnPost>
    {
        public StartupOnPostMap()
        {
            Id(x => x.Id).GeneratedBy.SequenceIdentity();
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedDate);

            References(x => x.Startup);
            References(x => x.Post);
        }
    }
}
