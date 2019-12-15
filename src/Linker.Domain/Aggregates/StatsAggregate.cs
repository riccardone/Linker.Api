using System;
using Evento;
using Linker.Domain.Commands;
using Linker.Domain.Events;
using Linker.Domain.Services;

namespace Linker.Domain.Aggregates
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
