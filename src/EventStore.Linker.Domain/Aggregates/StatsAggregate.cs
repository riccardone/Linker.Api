using System;
using System.Collections.Generic;
using System.Text;
using Evento;
using EventStore.Linker.Domain.Commands;
using EventStore.Linker.Domain.Events;
using EventStore.Linker.Domain.Services;

namespace EventStore.Linker.Domain.Aggregates
{
    public class StatsAggregate : AggregateBase
    {
        public override string AggregateId { get; }

        public StatsUpdated GetStats(GetStats cmd, IStatsService statsService)
        {
            throw new NotImplementedException();
        }
    }
}
