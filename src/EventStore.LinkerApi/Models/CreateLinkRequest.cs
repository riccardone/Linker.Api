using System.Collections.Generic;

namespace EventStore.LinkerApi.Models
{
    public class CreateLinkRequest
    {
        public string Id { get; set; }
        public LinkEdge Origin { get; set; }
        public LinkEdge Destination { get; set; }
        public List<LinkFilter> Filters { get; set; }
    }

    public class LinkEdge
    {
        public string ConnectionString { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string ConnectionName { get; set; }
    }

    public class LinkFilter
    {
        public FilterType FilterType { get; set; }
        public string Value { get; set; }
        public FilterOperation FilterOperation { get; set; }
    }

    public enum FilterOperation
    {
        Include,
        Exclude
    }

    public enum FilterType
    {
        Stream,
        EventType
    }
}
