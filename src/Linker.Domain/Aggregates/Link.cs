using System;

namespace Linker.Domain.Aggregates
{
    public class Link
    {
        public Link(string id, string origin, string destination, bool isRunning, DateTime? startedAt)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            IsRunning = isRunning;
            StartedAt = startedAt;
        }

        public string Id { get; }
        public string Origin { get; }
        public string Destination { get; }
        public bool IsRunning { get; }
        public DateTime? StartedAt { get; }
    }
}
