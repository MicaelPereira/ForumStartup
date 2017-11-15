using FluentNHibernate.Mapping;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infra.Map
{
    class StartupMap : ClassMap<Startup>
    {
        public StartupMap()
        {
            Id(x => x.Id).GeneratedBy.SequenceIdentity();
            Map(x => x.Name);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedDate);
        }
    }
}
