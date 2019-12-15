using System;
using Evento;
using Linker.Domain.Commands;

namespace Linker.Domain.Aggregates
{
    public class LinkAggregate : AggregateBase
    {
        public override string AggregateId { get; }

        public static LinkAggregate Create(CreateLink cmd)
        {
            throw new NotImplementedException();
        }

        public void Start(StartReplica cmd)
        {
            throw new NotImplementedException();
        }

        public void Stop(StopReplica cmd)
        {
            throw new NotImplementedException();
        }
    }
}
