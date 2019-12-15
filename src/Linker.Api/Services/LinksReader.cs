using System;
using System.Collections.Generic;
using Linker.Api.Models;

namespace Linker.Api.Services
{
    public class LinksReader : ILinksReader
    {
        public ExistingLink Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExistingLink> Get()
        {
            return new List<ExistingLink>
            {
                new ExistingLink
                {
                    Id = Guid.NewGuid().ToString(),
                    Origin = "origin-01",
                    Destination = "dest-01",
                    IsRunning = false,
                    StartedAt = DateTime.Today,
                    Stats = new List<IDictionary<string, string>> { new Dictionary<string, string>{{"ciccio", "bello"}}}
                },
                new ExistingLink
                {
                    Id = Guid.NewGuid().ToString(),
                    Origin = "origin-02",
                    Destination = "dest-02",
                    IsRunning = false,
                    StartedAt = DateTime.Today,
                    Stats = new List<IDictionary<string, string>> { new Dictionary<string, string>{{"ciccio", "mariano"}}}
                }
            };
        }
    }
}
