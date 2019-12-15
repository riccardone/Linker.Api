using System;
using System.Collections.Generic;

namespace EventStore.LinkerApi.Models
{
    public class ExistingLink
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public bool IsRunning { get; set; }
        public DateTime? StartedAt { get; set; }
        public IEnumerable<IDictionary<string, string>> Stats { get; set; }
    }
}
