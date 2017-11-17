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
            Map(x => x.Title);
            Map(x => x.Location);
            Map(x => x.Overview);
            Map(x => x.TypeOfStartup);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedDate);
        }
    }
}
